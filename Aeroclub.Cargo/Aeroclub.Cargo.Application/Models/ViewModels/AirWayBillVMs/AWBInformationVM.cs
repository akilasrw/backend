﻿using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs
{
    public class AWBInformationVM : BaseVM
    {
        public string? ShipperName { get; set; } = null;
        public string? ShipperAccountNumber { get; set; } = null;
        public string? ShipperAddress { get; set; } = null;
        public string? ConsigneeName { get; set; } = null;
        public string? ConsigneeAccountNumber { get; set; } = null;
        public string? ConsigneeAddress { get; set; } = null;
        public string? AgentName { get; set; } = null;
        public string? AgentCity { get; set; } = null;
        public string? AgentAITACode { get; set; } = null;
        public string? AgentAccountNumber { get; set; } = null;
        public string? AgentAccountInformation { get; set; } = null;
        public string? RequestedRouting { get; set; } = null;
        public string? RoutingAndDestinationTo { get; set; } = null;
        public string? RoutingAndDestinationBy { get; set; } = null;
        public DateTime RequestedFlightDate { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string? DestinationAirportCode { get; set; } = null;
        public string? ShippingReferenceNumber { get; set; } = null;
        public string? Currency { get; set; } = null;
        public double DeclaredValueForCarriage { get; set; }
        public double DeclaredValueForCustomer { get; set; }
        public double AmountOfInsurance { get; set; }
        public int AwbTrackingNumber { get; set; }

    }
}
