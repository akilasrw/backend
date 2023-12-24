using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.Queries.NotificationQMs;
using Aeroclub.Cargo.Application.Models.Queries.NotificationRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using static Grpc.Core.Metadata;

namespace Aeroclub.Cargo.Application.Services
{
    public class NotificationService : BaseService, INotificationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<NotificationVM> GetAsync(NotificationQM query)
        {
            var spec = new NotificationSpecification(query);
            var entity = await _unitOfWork.Repository<Notification>().GetEntityWithSpecAsync(spec, true);
            return _mapper.Map<Notification, NotificationVM>(entity);
        }
        public async Task<IReadOnlyList<NotificationVM>> GetListAsync(NotificationListQM query)
        {
            var spec = new NotificationSpecification(query);
            var list = await _unitOfWork.Repository<Notification>().GetListWithSpecAsync(spec, true);
            return _mapper.Map<IReadOnlyList<Notification>, IReadOnlyList<NotificationVM>>(list);
        }

        public async Task<Pagination<NotificationVM>> GetFilteredListAsync(NotificationFilterListQM query)
        {
            var spec = new NotificationSpecification(query);
            var list = await _unitOfWork.Repository<Notification>().GetListWithSpecAsync(spec, true);

            var countSpec = new NotificationSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<Notification>().CountAsync(countSpec);

            var dtoList =
                _mapper.Map<IReadOnlyList<Notification>, IReadOnlyList<NotificationVM>>(list);

            return new Pagination<NotificationVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _unitOfWork.Repository<Notification>().GetByIdAsync(id);
            _unitOfWork.Repository<Notification>().Delete(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Notification>().Detach(entity);
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }


        public async Task<bool> MarkAllAsReadAsync(Guid userId)
        {
            var spec = new NotificationSpecification(new NotificationListQM { UserId = userId, IsUnread = true });
            var list = await _unitOfWork.Repository<Notification>().GetListWithSpecAsync(spec);
            foreach (var entity in list)
            {
                entity.IsRead = true;
                _unitOfWork.Repository<Notification>().Update(entity);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<Notification>().Detach(entity);

            }
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

        public async Task<Tuple<bool, Guid>> MarkAsReadAsync(Guid id)
        {
            var entity = await _unitOfWork.Repository<Notification>().GetByIdAsync(id);
            entity.IsRead = true;
            _unitOfWork.Repository<Notification>().Update(entity);
            var response = await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Notification>().Detach(entity);
            return Tuple.Create(response > 0, entity.UserId);
        }

        public async Task<int> CountAsync(NotificationCountQM query)
        {
            var spec = new NotificationSpecification(query);
            var count = await _unitOfWork.Repository<Notification>().CountAsync(spec);
            return count;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(NotificationRM dto)
        {
            var response = new ServiceResponseCreateStatus();
            if (_httpContextAccessor.HttpContext.Items.TryGetValue("User", out var user))
            {
                if (user is AppUser userType)
                {
                    dto.UserId = userType.Id;

                }
            }
            var notification = _mapper.Map<Notification>(dto);
            await _unitOfWork.Repository<Notification>().CreateAsync(notification);
            await _unitOfWork.SaveChangesAsync();
            response.Id = notification.Id;
            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }
    }
}
