using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SystemUserVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using BC = BCrypt.Net.BCrypt;

namespace Aeroclub.Cargo.Application.Services
{
    public class ManageUserService : BaseService, IManageUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSenderService _emailService;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPasswordGeneratorService _passwordGeneratorService;

        public ManageUserService(UserManager<AppUser> userManager,
            IPasswordGeneratorService passwordGeneratorService,
            IEmailSenderService emailService,
            //RoleManager<IdentityRole> roleManager,
            IUnitOfWork unitOfWork, IMapper mapper) 
            : base(unitOfWork, mapper)
        {
            _userManager = userManager;
            _emailService = emailService;
            //_roleManager = roleManager;
            _passwordGeneratorService = passwordGeneratorService;
        }

        public async Task<SystemUserVM> GetAsync(SystemUserQM query)
        {

            var spec = new SystemUserSpecification(query);
            var cargoAgent = await _unitOfWork.Repository<SystemUser>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<SystemUser, SystemUserVM>(cargoAgent);
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(SystemUserCreateRM model)
        {
            SystemUser createdUser;

            var response = new ServiceResponseCreateStatus();
            var appUser = _mapper.Map<AppUser>(model);
            
            // Generate Password
            string password = _passwordGeneratorService.GeneratePasswordStrongPassword();

            // Send Password via email to the user
            await _emailService.SendEmailAsync(new Infrastructure.Models.EmailRequest()
            {
                ToMail = appUser.Email,
                ToName = model.FirstName,
                Subject ="New Sign in Password",
                Body = GenerateEmailBody(password, model.FirstName),
                HtmlBody = GenerateEmailHtmlBody(password, model.FirstName)
            });

            // hash password
            appUser.PasswordHash = BC.HashPassword(password);

            var createdAppUser = await _userManager.CreateAsync(appUser);

            if (createdAppUser.Succeeded)
            {
                var user = _mapper.Map<SystemUser>(model);

                user.AppUserId = appUser.Id;

                createdUser = await _unitOfWork.Repository<SystemUser>().CreateAsync(user);
                await _unitOfWork.SaveChangesAsync();

                // Mapping and save app role detail
                string roleName = model.UserRole.GetDescription();
                await _userManager.AddToRoleAsync(appUser, roleName);
                //await AssignRoleAsync(appUser, role);

                response.Id = createdUser.Id;
                response.StatusCode = ServiceResponseStatus.Success;
            }
            else
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                response.Message = createdAppUser.Errors.First().Description;
            }

            return response;
        }

        public async Task<bool> StatusUpdateAsync(SystemUserStatusUpdateRM rm)
        {
            var entity = await _unitOfWork.Repository<SystemUser>().GetByIdAsync(rm.Id, false);
            entity.UserStatus = rm.UserStatus;
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<Pagination<SystemUserVM>> GetFilteredListAsync(SystemUserListQM query)
        {
            var spec = new SystemUserSpecification(query);

            var agentList = await _unitOfWork.Repository<SystemUser>().GetListWithSpecAsync(spec);

            var countSpec = new SystemUserSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<SystemUser>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<SystemUserVM>>(agentList);

            return new Pagination<SystemUserVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        private async Task AssignRoleAsync(AppUser user, string roleName)
        {
            //var roleExists = await _roleManager.RoleExistsAsync(roleName);
            //if (roleExists)
               
        }
     
        string GenerateEmailBody(string password, string name)
        {
            string text = "Dear {0}\n, Your sign in password is {1}";
            return string.Format(text, name, password);
        }

        string GenerateEmailHtmlBody(string password, string name)
        {
            string text = "Dear {0}<br/><br/>, Your password sign in is <strong>{1}</strong>";
            return string.Format(text, name, password);
        }
    }
}
