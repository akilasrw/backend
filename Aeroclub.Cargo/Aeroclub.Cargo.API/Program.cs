using System;
using System.Linq;
using Aeroclub.Cargo.API.Extensions;
using Aeroclub.Cargo.API.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.ResolveConflictingActions (apiDescriptions => apiDescriptions.First());
});
builder.Services.AddDBContextServices(builder.Configuration);
builder.Services.AddApplicationServices();
var clientUrlSettings = builder.Configuration.GetSection("ClientSettings")["ClientBaseUrl"];
var urlList = clientUrlSettings.Split(";");
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins(urlList);
    });
});
builder.Services.AddControllers();
builder.Services.AddAuthentication(auth =>
    {
        auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:Secret"])),
            ValidIssuer = builder.Configuration["Token:Issuer"],
            ValidateIssuer = false,
            RequireExpirationTime = true,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero,
            ValidateAudience = false
        };
    });

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = ApiVersion.Default;
    options.ReportApiVersions = true;
});

builder.Services.AddIdentityCore<AppUser>(options =>
    {
        options.SignIn.RequireConfirmedEmail = true;
        options.Lockout.MaxFailedAccessAttempts = 10;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(Int16.MaxValue);
    })
    .AddRoles<AppRole>()
    .AddRoleManager<RoleManager<AppRole>>()
    .AddSignInManager<SignInManager<AppUser>>()
    .AddRoleValidator<RoleValidator<AppRole>>()
    .AddEntityFrameworkStores<CargoContext>().AddDefaultTokenProviders();

builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CargoContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();

// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.UseHttpsRedirection();
app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();