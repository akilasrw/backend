using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Aeroclub.Cargo.Application.Specifications;
using BC = BCrypt.Net.BCrypt;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LIRFileUploadQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoAgentService :BaseService, ICargoAgentService
    {
       
        private readonly UserManager<AppUser> _userManager;
        private readonly IUploadFactory _uploadFactory;


        public CargoAgentService(UserManager<AppUser> userManager, IUnitOfWork unitOfWork, IMapper mapper, IUploadFactory uploadFactory):
            base(unitOfWork,mapper)
        {
            _userManager = userManager;
            _uploadFactory = uploadFactory;
        }


        public async Task<CargoAgentCreateStatusRM?> CreateAsync(CargoAgentCreateRM model)
        {
            CargoAgent createdUser;

            if (model.AgreementFile != null)
            {
                var service = _uploadFactory.CreateUploadServiceAsync(UploadStorageType.Blob);
                var uploadedFile = service.Upload(model.AgreementFile);

                var response = new CargoAgentCreateStatusRM();

                var appUser = _mapper.Map<AppUser>(model);

                // hash password
                appUser.PasswordHash = BC.HashPassword(model.Password);

                appUser.Agreement = uploadedFile.FileName;

                var createdAppUser = await _userManager.CreateAsync(appUser);

                if (createdAppUser.Succeeded)
                {
                  
                    try
                    {
                        var user = _mapper.Map<CargoAgent>(model);

                        user.AppUserId = appUser.Id;

                        createdUser = await _unitOfWork.Repository<CargoAgent>().CreateAsync(user);
                        await _unitOfWork.SaveChangesAsync();

                        var roleName = UserRole.BookingUser;
                        await _userManager.AddToRoleAsync(appUser, roleName.GetDescription());

                        response.Id = createdUser.Id;
                        response.StatusCode = ServiceResponseStatus.Success;

                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    

                  
                }
                else
                {
                    response.StatusCode = ServiceResponseStatus.Failed;
                    response.ErrorMessage = createdAppUser.Errors.First().Description;
                }

                return response;
            }
            else
            {
                return null;
            }

            




            

            
        }

        

        public async Task<ServiceResponseStatus> UpdateAsync(CargoAgentUpdateRM user)
        {
            var agentQry = new CargoAgentQM();
            agentQry.Id = user.Id;

            var savedUser = await GetAsync(agentQry);
            user.AppUserId = (Guid)savedUser.AppUserId;

            if (savedUser.Email != user.Email || 
                savedUser.PrimaryTelephoneNumber != user.PrimaryTelephoneNumber || 
                savedUser.UserName != user.UserName)
            {
                var appuser = await _userManager.FindByIdAsync(user.AppUserId.ToString());
                appuser.Email = user.Email;
                appuser.UserName = user.UserName;
                appuser.PhoneNumber = user.PrimaryTelephoneNumber;
                await _userManager.UpdateAsync(appuser);

            }
     
            var entity = _mapper.Map<CargoAgentUpdateRM, CargoAgent>(user);
            _unitOfWork.Repository<CargoAgent>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<CargoAgent>().Detach(entity);
            
            return ServiceResponseStatus.Success;
        }

        public async Task<bool> StatusUpdateAsync(CargoAgentStatusUpdateRM rm)
        {
            var entity = await _unitOfWork.Repository<CargoAgent>().GetByIdAsync(rm.Id, false);
            entity.Status = rm.Status ;
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<CargoAgentVM> GetAsync(CargoAgentQM query)
        {

            var spec = new CargoAgentSpecification(query);
            var cargoAgent = await _unitOfWork.Repository<CargoAgent>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<CargoAgent, CargoAgentVM>(cargoAgent);
        }
        
        public async Task<IReadOnlyList<CargoAgentVM>> GetListAsync()
        {

            var spec = new CargoAgentSpecification();
            var cargoAgent = await _unitOfWork.Repository<CargoAgent>().GetListWithSpecAsync(spec);

            return _mapper.Map<IReadOnlyList<CargoAgent>, IReadOnlyList<CargoAgentVM>>(cargoAgent);
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var entity = await _unitOfWork.Repository<CargoAgent>().GetByIdAsync(Id,false);
            entity.IsDeleted = true;
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

        public async Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync()
        {
            var list = await _unitOfWork.Repository<CargoAgent>().GetListWithSpecAsync(new CargoAgentSpecification());
            return _mapper.Map<IReadOnlyList<BaseSelectListModel>>(list);
        }

        public async Task<Pagination<CargoAgentVM>> GetFilteredListAsync(CargoAgentListQM query)
        {
            var spec = new CargoAgentSpecification(query);

            var agentList = await _unitOfWork.Repository<CargoAgent>().GetListWithSpecAsync(spec);

            var countSpec = new CargoAgentSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<CargoAgent>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<CargoAgentVM>>(agentList);

            return new Pagination<CargoAgentVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }
    }
}
