using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.Queries.DeliveryAuditQM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ChartVM;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Google.Type;

namespace Aeroclub.Cargo.Application.Services
{
    public class CargoBookingLookupService : BaseService,ICargoBookingLookupService
    {
        public CargoBookingLookupService(IUnitOfWork unitOfWork,IMapper mapper):
            base(unitOfWork,mapper)
        {
                
        }
        public async Task<CargoBookingLookupVM?> GetAsync(CargoBookingLookupQM query)
        {
                var spec = new CargoBookingLookupSpecification(query);

                var entity = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(spec);

                if (entity != null)
                {
                    var mappedEntity = _mapper.Map<CargoBookingLookupVM>(entity);

                    mappedEntity = GetCargoBookingSectorInfo(entity, mappedEntity);

                var rates = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(new AgentRateManagementSpecification());

                var weight = mappedEntity.PackageItems.Sum(x => x.Weight);

                AgentRate rate = null;

                if (weight < 45)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Minus45K);
                }
                else if (weight >= 45 && weight < 100)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Plus45K);
                }
                else if (weight >= 100 && weight < 300)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Plus100K);
                }
                else if (weight >= 300 && weight < 500)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Plus300K);
                }
                else if (weight >= 500 && weight < 1000)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Plus500K);
                }
                else if (weight >= 1000)
                {
                    rate = rates.AgentRates
                                .FirstOrDefault(x => x.WeightType == WeightType.Plus1000K);
                }


                mappedEntity.AWBInformation.RateCharge = rate.Rate;
                mappedEntity.AWBInformation.Weight = weight;
                mappedEntity.AWBInformation.Total = weight * rate.Rate;
                mappedEntity.AWBInformation.NumOfPackages = mappedEntity.PackageItems.Count();





                return mappedEntity;
                }
            return null;
        }

        public async Task<ChartVM> GetChartData(DeliveryAuditQM query)
        {
            var spec = new DeliveryAuditSpecification(query);

            var data = await _unitOfWork.Repository<DeliveryAudit>().GetListWithSpecAsync(spec);

            var chart = new ChartVM { Collected = data.Sum((x) => x.ParcellsCollected), OneDay = data.Sum(x => x.OneDay) , Deliverd = data.Sum(x => x.ParcellsDeliverd), OneAndHalf = data.Sum(x => x.OneDayToOneAndHalf), AfterOneAndHalf= data.Sum(x => x.AfterOneAndHalf) };
           
            return chart;
        }

        public async Task<IReadOnlyList<DeliveryAudit>> GetDeliveryAudit(DeliveryAuditQM query)
        {
            
            var spec = new DeliveryAuditSpecification(query);

            return await _unitOfWork.Repository<DeliveryAudit>().GetListWithSpecAsync(spec);
        }

        private CargoBookingLookupVM GetCargoBookingSectorInfo(CargoBooking cargoBooking, CargoBookingLookupVM bookingDetail)
        {
            var orderedCrgoBookingFlightScheduleSectors = cargoBooking.CargoBookingFlightScheduleSectors.OrderBy(x => x.FlightScheduleSector.SequenceNo).ToList();
            var lastCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.Last();
            bookingDetail.DestinationAirportCode = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.DestinationAirportCode;
            bookingDetail.ScheduledDepartureDateTime = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.ScheduledDepartureDateTime;
            bookingDetail.FlightNumber = lastCrgoBookingFlightScheduleSector.FlightScheduleSector.FlightNumber;

            var firstCrgoBookingFlightScheduleSector = orderedCrgoBookingFlightScheduleSectors.First();
            bookingDetail.OriginAirportCode = firstCrgoBookingFlightScheduleSector.FlightScheduleSector.OriginAirportCode;
            return bookingDetail;
        }
    }
}
