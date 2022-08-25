namespace Aeroclub.Cargo.Common.Enums
{

    public enum AircraftSubTypes
    {
        None = 0,
        B7879TypeOne = 1,
        A320200TypeOne = 2,
        B737400TypeOne = 3,

    }

    public enum AircraftTypes
    {
        None = 0,
        B7879 = 1,
        A320200 = 2,
        B737400 = 3,
    }

    public enum AircraftConfigType
    {
        None = 0,
        P2C = 1,
        Freighter = 2,
    }

    public enum AircraftStatus
    {
        None = 0,
        Charter = 1,
        Schedule = 2,
        Maintenance = 3,
    }

    public enum SectorType
    {
        None = 0,
        Domestic = 1,
        International = 2
    }

    public enum FlightScheduleStatus
    {
        None = 0,
        OnTime = 1,
        Delayed = 2
    }

    public enum LoadPlanStatus
    {
        None = 0,
        Processing = 1,
        Finalized = 2
    }

    public enum ULDType
    {
        None = 0,
        LD1 = 1,
        LD2 = 2
    }

    public enum ULDContainerType
    {
        None = 0,
        ULD = 1,
        Box = 2
    }

    public enum AircraftDeckType
    {
        None = 0,
        MainDeck = 1,
        Belly = 2
    }

    public enum UnitType
    {
        None = 0,
        Length = 1,
        Mass = 2
    }

    public enum BookingStatus
    {
        None = 0,
        Pending = 10,
        Accepted = 20,
        Loading = 30,
        Invoiced = 40,
        Dispatched = 50,
        Exported = 60
    }

    public enum PackagePriorityType
    {
        None = 0,
        Urgent = 1
    }

    public enum PackageItemStatus
    {
        None = 0,
        Pending = 1
    }

    public enum AWBStatus
    {
        None = 0,
        Pending = 1,
        AddedAWB = 2
    }

    public enum PackageItemCategory
    {
        None = 0,
        General = 1,
        Animal = 2,
        Artwork = 3,
        Dgr = 4
    }
    public enum PackageContainerType
    {
        None = 0,
        OnFloor = 1,
        OnOneSeat = 2,
        UnderSeat = 3,
        Overhead = 4,
        OnThreeSeats = 5
    }

    public enum CargoPositionType
    {
        None = 0,
        OnFloor = 1,
        OnSeat = 2,
        UnderSeat = 3,
        Overhead = 4
    }

    public enum SeatConfigurationType
    {
        None = 0,
        SingleSeat = 1,
        TwoSeats = 2,
        ThreeSeats = 3,
        FourSeats = 4
    }

    public enum CargoReferenceNumberType
    {
        Booking = 1,
        Package = 2
    }

    public enum PackageBoxType
    {
        Container = 1,
        CustomBox = 2
    }

    public enum PackageProductType
    {
        None = 0,
        Electronic = 1,
        Stationery = 2
    }

    public enum AircraftActiveTypes
    {
        None = 0,
        Active = 1,
        Inactive = 2
    }
}