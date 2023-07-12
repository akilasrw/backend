﻿using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Authorization.Models
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }

        //[JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }
        public bool IsAutoGeneratedPassword { get; set; }

        public AuthenticateResponse(AppUser user, string jwtToken, string refreshToken)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.UserName;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
            IsAutoGeneratedPassword = user.IsAutoGeneratedPassword;
        }
    }
}
