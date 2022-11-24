using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class LinkAircraftToScheduleService : BaseService, ILinkAircraftToScheduleService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IAircraftService _aircraftService;

        public LinkAircraftToScheduleService(IUnitOfWork unitOfWork,
            IMapper mapper, 
            IFlightScheduleService flightScheduleService,
            IAircraftService aircraftService) 
            : base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _aircraftService = aircraftService;
        }
        public async Task<ServiceResponseStatus> CreateAsync(ScheduleAircraftRM query)
        {
            var status = ServiceResponseStatus.Success;
            if (!await ValidAircraftAsync(query))
                return ServiceResponseStatus.ValidationError;

            var spec = new FlightScheduleSpecification(new FlightScheduleLinkQM { FlightScheduleId = query.FlightScheduleId, IncludeFlightScheduleSectors = true, IncludeAircrafts=true });
            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);
            if (flightSchedule != null)
            {
                flightSchedule.AircraftId = query.AircraftId;
                flightSchedule.AircraftRegNo = await _aircraftService.GetAircraftRegNo(query.AircraftId);
                flightSchedule.AircraftScheduleId = query.AircraftScheduleId;
            }

            _unitOfWork.Repository<FlightSchedule>().Update(flightSchedule);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<FlightSchedule>().Detach(flightSchedule);

            var specSector = new FlightScheduleSectorSpecification(new FlightScheduleSectorSearchQuery() { FlightScheduleId = query.FlightScheduleId });
            var flightScheduleSectors = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(specSector);
            foreach (var sector in flightScheduleSectors)
            {
                sector.AircraftId = query.AircraftId;
                _unitOfWork.Repository<FlightScheduleSector>().Update(sector);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<FlightScheduleSector>().Detach(sector);
            }
            return status;
        }

        public async Task<Pagination<FlightScheduleManagementLinkAircraftVM>> GetLinkAircraftFilteredListAsync(FlightScheduleManagemenLinktFilteredListQM query)
        {
            var spec = new FlightScheduleManagementSpecification(query);
            var flightScheduleManagementList = await _unitOfWork.Repository<FlightScheduleManagement>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleManagementSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightScheduleManagement>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleManagementLinkAircraftVM>>(flightScheduleManagementList);
            return   new Pagination<FlightScheduleManagementLinkAircraftVM>(query.PageIndex, query.PageSize, totalCount, dtoList);;
        }

        private async Task<bool> ValidAircraftAsync(ScheduleAircraftRM query)
        {
            bool valid = false;
            IReadOnlyList<AircraftDto> availableAircrafts = await _flightScheduleService.GetAvailableAircrafts_ByFlightScheduleIdAsync(query.FlightScheduleId);
            if (availableAircrafts.Where(x => x.Id == query.AircraftId).ToList().Count() > 0)
                valid = true;

            var fsSpec = new FlightScheduleSpecification(query.AircraftScheduleId.Value); // Get FlightSchedule from aircraft Schedule Id. 
            IReadOnlyList<FlightSchedule> flightSchedule_AlreadyLinked = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(fsSpec);

            if (flightSchedule_AlreadyLinked == null || flightSchedule_AlreadyLinked.Count == 0)
                valid = true;

            return valid;
        }
    }
}
