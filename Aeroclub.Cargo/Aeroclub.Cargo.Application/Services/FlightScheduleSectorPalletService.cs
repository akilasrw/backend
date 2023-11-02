﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorPalletQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleSectorPalletService : BaseService, IFlightScheduleSectorPalletService
    {
        private readonly ICargoBookingSummaryService _cargoBookingSummaryService;

        public FlightScheduleSectorPalletService(ICargoBookingSummaryService cargoBookingSummaryService, IMapper mapper, IUnitOfWork unitOfWork) :
            base(unitOfWork, mapper)
        {
            _cargoBookingSummaryService = cargoBookingSummaryService;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorPalletCreateRM rm)
        {
            var flightScheduleSectorPallet = _mapper.Map<FlightScheduleSectorPallet>(rm);

            if (await ValidCountAsync(rm) == false) 
                return new ServiceResponseCreateStatus() { Message = "Pallete assignment qty is exeeded", StatusCode = ServiceResponseStatus.ValidationError };

            var entity = await _unitOfWork.Repository<FlightScheduleSectorPallet>().CreateAsync(flightScheduleSectorPallet);
            await _unitOfWork.SaveChangesAsync();
            var response = new ServiceResponseCreateStatus() { Id = entity.Id, StatusCode = ServiceResponseStatus.Success };

            return response;
        }
        
        public async Task<bool> DeleteAsync(FlightScheduleSectorPallet entity)
        {
            _unitOfWork.Repository<FlightScheduleSectorPallet>().Delete(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<FlightScheduleSectorPallet>().Detach(entity);
            return true;
        }

        public async Task<ServiceResponseStatus> CreateRemovePalletListAsync(FlightScheduleSectorPalletCreateListRM request)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var deleted = true;
                if (request.FlightScheduleSectorPalletRMs.Any(x => x.IsAdded == false)) // Deleting process
                {
                    var needtoDeleted = request.FlightScheduleSectorPalletRMs.Where(x => x.IsAdded == false).ToList();
                    deleted = await DeleteListAsync(needtoDeleted);
                }

                if (deleted)
                    foreach (var rm in request.FlightScheduleSectorPalletRMs.Where(x => x.IsAdded).ToList()) // Adding process
                    {
                        var res = await CreateAsync(rm);
                        if (res.StatusCode == ServiceResponseStatus.Success)
                        {

                            transaction.Rollback();
                            return res.StatusCode;
                        }
                    }
                transaction.Commit();
            }
            return ServiceResponseStatus.Success;
        }

       
        public async Task<List<ULDVM>> GetPalleteListAsync(FlightSheduleSectorPalletGetList palletFilter)
        {
            List<ULD> allocatedUldList = new List<ULD>();
            // Get already Assigned Ulds
            var pallets = await _unitOfWork.Repository<FlightScheduleSectorPallet>()
                .GetListWithSpecAsync(new FlightScheduleSectorPalletSpecification(new FlightScheduleSectorPalletQuery() { FlightScheduleSectorId = palletFilter.FlightScheduleId, IncludeUld = true, IncludeFlightSchedule = true }));

            foreach (var pallet in pallets.ToList())
            {
                allocatedUldList.Add(pallet.ULD);
            }

            // Get All Ulds
            var allUlds = await _unitOfWork.Repository<ULD>().GetListAsync();

            // exclude allocated list
            var otherlist = allUlds
                .Except(allocatedUldList)
                .ToList();

            List<ULDVM> uldVMList = new List<ULDVM>();

            foreach (var item in otherlist) {
                var vmItem = _mapper.Map<ULDVM>(item);
                uldVMList.Add(vmItem);
            }

            foreach (var item in allocatedUldList)
            {
                var vmItem = _mapper.Map<ULDVM>(item);
                vmItem.IsAssigned = true;
                vmItem.AllocatedFlightNumber = palletFilter.FlightScheduleId;
                uldVMList.Add(vmItem);
            }
            return uldVMList;
            //foreach (var uld in ulds)
            //{
            //    pallets.Where(x => x.ULDId == uld.Id);
            //}

            //var assingedUlds = ulds.Join(
            //    pallets,
            //    uld => uld.Id,
            //    pallet => pallet.ULDId,
            //    (uld, pallet) => new
            //    {
            //        uld.SerialNumber,
            //        pallet.ULDId,
            //    })
            //    .ToList();



            // Filtered avaialble Ulds
            // -- Not used in same flight date

        }

        async Task<bool> DeleteListAsync(IEnumerable<FlightScheduleSectorPalletCreateRemoveRM> requests)
        {
            foreach (var req in requests)
            {
                var flightScheduleSectorPallet = await _unitOfWork.Repository<FlightScheduleSectorPallet>().GetEntityWithSpecAsync(
                    new FlightScheduleSectorPalletSpecification(
                        new FlightScheduleSectorPalletQuery() { 
                        FlightScheduleSectorId = req.FlightScheduleSectorId, 
                        ULDId = req.ULDId 
                    }));
                if(flightScheduleSectorPallet!= null)
                    await DeleteAsync(flightScheduleSectorPallet);
            }
            return true;
        }

        async Task<bool> ValidCountAsync(FlightScheduleSectorPalletCreateRM rm)
        {
            bool valid = true;

            //---- get max uld qty---
            // get zone id from loadplan id
            var spec = new FlightScheduleSectorSpecification(
                new FlightScheduleSectorQM() { Id = rm.FlightScheduleSectorId, IncludeLoadPlan = true, IncludeULDContaines = true, IncludeFlightScheduleSectorPallets = true });
            var fs = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            if (fs != null)
            {
                //int posCount = fs.LoadPlan.AircraftLayout.AircraftDecks.FirstOrDefault().AircraftCabins.FirstOrDefault().ZoneAreas.FirstOrDefault().CargoPositions.Count();
                var list = await _cargoBookingSummaryService.GetAircraftPositionList(rm.FlightScheduleSectorId);
                int posCount = list.Count();
                if (fs.FlightScheduleSectorPallets.Count() >= posCount)
                    valid = false;
            }
            // get cargo position from CargoPositions entity => y
            // get added pallet from FlightScheduleSectorPallet => x.

            // if(y>x) return false;

            return valid;
        }
    }
}
