using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.NotificationQMs;
using Aeroclub.Cargo.Application.Models.Queries.NotificationRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs;
using Aeroclub.Cargo.Application.Services;
using Aeroclub.Cargo.Infrastructure.Interfaces;
using Aeroclub.Cargo.Infrastructure.Models.FirebaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class NotificationController : BaseApiController
    {
        private readonly INotificationService _notificationService;
        private readonly IFirebaseService _firebaseService;

        public NotificationController(INotificationService notificationService, IFirebaseService firebaseService)
        {
            _notificationService = notificationService;
            _firebaseService = firebaseService;
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<NotificationVM>> GetAsync([FromQuery] NotificationQM query)
        {
            var result = await _notificationService.GetAsync(query);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("getList")]
        public async Task<ActionResult<IReadOnlyList<NotificationVM>>> GetListAsync([FromQuery] NotificationListQM query)
        {
            return Ok(await _notificationService.GetListAsync(query));
        }

        [HttpGet("getFilteredList")]
        public async Task<ActionResult<Pagination<NotificationVM>>> GetFilteredList([FromQuery] NotificationFilterListQM query)
        {
            return Ok(await _notificationService.GetFilteredListAsync(query));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            return Ok(await _notificationService.DeleteAsync(id));
        }

        [HttpPut("markAsRead")]
        public async Task<ActionResult<bool>> MarkAsReadAsync([FromBody] Guid id)
        {
            var response = await _notificationService.MarkAsReadAsync(id);
            /*
            if (response.Item1)
            {
                var count = await _notificationService.CountAsync(new NotificationCountQM { UserId = response.Item2, IsUnread = true });

                 var model = new FirebaseUserModel
                 {
                     UnreadNotificationAvailable = count != 0,
                     UnreadNotificationCount = count
                 };

                 await _firebaseService.SetDocumentAsync("users", response.Item2.ToString(), model);
             }*/

            return Ok(response.Item1);
        }

        [HttpPut("markAllAsRead")]
        public async Task<ActionResult<bool>> MarkAllAsReadAsync([FromBody] Guid userId)
        {
            var response = await _notificationService.MarkAllAsReadAsync(userId);
            /*if (response)
            {
                var count = await _notificationService.CountAsync(new NotificationCountQM { UserId = userId, IsUnread = true });

                var model = new FirebaseUserModel
                {
                    UnreadNotificationAvailable = count != 0,
                    UnreadNotificationCount = count
                };

                await _firebaseService.SetDocumentAsync("users", userId.ToString(), model);
            }*/
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] NotificationRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _notificationService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Notification add fails.");
        }

    }
}
