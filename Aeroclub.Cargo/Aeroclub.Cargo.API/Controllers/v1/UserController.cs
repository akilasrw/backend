using System;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Common;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Infrastructure.Authorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [Authorize]
    public class UserController : BaseApiController
    {
        private IUserService _userService;
        private readonly UserManager<AppUser> _userManager;

        public UserController(IUserService userService, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            bool isValid;
            var msg = CheckValidPermission(model.Username, AccessPortalLevel.Backoffice, out isValid);
            if(!isValid)  return Unauthorized(msg);

            var response = _userService.Authenticate(model, ipAddress());
            
            if (response.Status == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            setTokenCookie(response.Response.RefreshToken);
            return Ok(response.Response);
        }

        [AllowAnonymous]
        [HttpPost("cargo-agent-authenticate")]
        public IActionResult CargoAgentAuthenticate(AuthenticateRequest model)
        {
            bool isValid;
            var msg = CheckValidPermission(model.Username, AccessPortalLevel.Booking, out isValid);
            if (!isValid) return Unauthorized(msg);

            var response = _userService.CargoAgentAuthenticate(model, ipAddress());

            if (response.Status == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            setTokenCookie(response.Response.RefreshToken);
            return Ok(response.Response);
        }
        
        
        [AllowAnonymous]
        [HttpPost("warehouse-authenticate")]
        public IActionResult WarehouseAuthenticate(AuthenticateRequest model)
        {
            bool isValid;
            var msg = CheckValidPermission(model.Username, AccessPortalLevel.WareHouse, out isValid);
            if (!isValid) return Unauthorized(msg);

            var response = _userService.CargoAgentAuthenticate(model, ipAddress());

            if (response.Status == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            setTokenCookie(response.Response.RefreshToken);
            return Ok(response.Response);
        }

        private string CheckValidPermission(string username, AccessPortalLevel accessPortalLevel , out bool isValid) 
        {
            var user = _userManager.FindByNameAsync(username).Result;
            if (user == null)
            {
                isValid = false;
                return CommonMessages.InvalidUsername;
            }

            var userRole = _userManager.GetRolesAsync(user).Result;
            if (userRole.Count == 0)
            {
                isValid = false;
                return CommonMessages.PermissionDenied;
            }

            if (!IsValidSystemUser(accessPortalLevel, userRole))
            {
                isValid = false;
                return CommonMessages.NoAccessPortal;
            }

            isValid = true;
            return "";
        }

        private bool IsValidSystemUser(AccessPortalLevel accessPortalLevel, IList<string> userRole)
        {
            if (userRole.Count > 0)
            {
                if (userRole.FirstOrDefault(x => x.Contains("Super Admin")) != null) return true;

                switch (accessPortalLevel)
                {
                    case AccessPortalLevel.Booking:
                        if (userRole.FirstOrDefault(x => x.Contains("Booking")) != null) return true;
                        break;
                    case AccessPortalLevel.WareHouse:
                        if (userRole.FirstOrDefault(x => x.Contains("WareHouse")) != null) return true;
                        break;
                    case AccessPortalLevel.Backoffice:
                        if (userRole.FirstOrDefault(x => x.Contains("Backoffice")) != null) return true;
                        break;
                }
            }

            return false;
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public IActionResult RefreshToken([FromBody] string refreshToken)
        {
            // var refreshToken = Request.Cookies["refreshToken"]; // Cookies is not working at appService

            if (string.IsNullOrEmpty(refreshToken)) // Code added  by Yohan.
                return Unauthorized("refresh token is not created.");
            
            var response = _userService.RefreshToken(refreshToken, ipAddress());
            
            if (response.Status == Application.Enums.ServiceResponseStatus.ValidationError)
                return Unauthorized(response.Message);

            setTokenCookie(response.Response.RefreshToken);
            return Ok(response.Response);
        }

        [AllowAnonymous]
        [HttpPost("mobile/refresh-token")]
        public IActionResult RefreshTokenMobile([FromBody] string refreshToken)
        {

            if (string.IsNullOrEmpty(refreshToken))
                return Unauthorized("refresh token is not created.");

            var response = _userService.RefreshToken(refreshToken, ipAddress());

            if (response.Status == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            setTokenCookie(response.Response.RefreshToken);
            return Ok(response.Response);
        }

        [AllowAnonymous]
        [HttpPost("updatePassword")]
        public IActionResult UpdatePassword([FromBody] UserPasswordRequest req)
        {
            var result = _userService.UpdatePassword(req);
            if(!result) return BadRequest("Password update is failed.");
            return NoContent();
        }

        [HttpPost("revoke-token")]
        public IActionResult RevokeToken(RevokeTokenRequest model)
        {
            // accept refresh token in request body or cookie
            var token = model.Token ?? Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(token))
                return BadRequest("Token is required");

            _userService.RevokeToken(token, ipAddress());
            return Ok(new { message = "Token revoked" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpGet("{id}/refresh-tokens")]
        public IActionResult GetRefreshTokens(Guid id)
        {
            var user = _userService.GetById(id);
            return Ok(user.RefreshTokens);
        }

        // helper methods

        private void setTokenCookie(string token)
        {
            // append cookie with refresh token to the http response
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7),
                SameSite =  SameSiteMode.Lax,
                Path = "/",
                Secure = true
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        private string ipAddress()
        {
            // get source ip address for the current request
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }
}
