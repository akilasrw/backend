using System.ComponentModel;

namespace Aeroclub.Cargo.Common.Enums
{

    public enum AircraftSubTypes
    {
        None = 0,
        B7879TypeOne = 1,
        A320200TypeOne = 2,
        B737400TypeOne = 3,
        B737800TypeOne = 4,
        B737300TypeOne = 5

    }

    public enum AircraftTypes
    {
        None = 0,
        B7879 = 1,
        A320200 = 2,
        B737400 = 3,
        B737800 = 4,
        B737300 = 5
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
    public enum FlightScheduleOrderStatus
    {
        None = 0,
        InProgress = 1,
        Dispatched = 2,
        Cancelled = 3,
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
        Pallet = 1,
        Container = 2
    }

    public enum ULDOwnershipType
    {
        None = 0,
        OwnByAirline = 1,
        Other = 2
    }
    public enum ULDLocateStatus
    {
        None = 0,
        OnGround = 1,
        OnBoard = 2,
        Maintenance = 3,
        Lend = 4,
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
        Booking_Made = 10, 
        AWB_Added = 20,
        Cargo_Received = 30,
        Off_Loaded = 40,
        Flight_Dispatched = 50,
        Flight_Arrived = 60,
        Cancelled = 70
    }

    public enum PackagePriorityType
    {
        None = 0,
        Urgent = 1
    }

    public enum PackageItemStatus
    {
        Booking_Made = 0,
        Cargo_Received = 1,
        Dispatched = 2,
        Arrived = 4,
    }

    public enum AWBStatus
    {
        None = 0,
        Pending = 1,
        AddedAWB = 2
    } 
    
    public enum VerifyStatus
    {
        None = 0,
        ActualLoad = 1,
        OffLoad = 2,
        Dispatched = 3,
        Deleted = 4,
        CargoNotDispatched = 5
    }

    public enum StandByStatus
    {
        None = 0,
        MovedTo = 1,
        OffLoad = 2
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
    public enum AircraftActiveTypes
    {
        None = 0,
        Active = 1,
        Inactive = 2
    }

    public enum WeightType
    {
        None = 0,
        M = 1,
        Minus45K = 2,
        Plus45K = 3,
        Plus100K = 4,
        Plus300K = 5,
        Plus500K = 6,
        Plus1000K = 7,
    }

    public enum DBTransactionStatus
    {
        None = 0,
        Updated = 1,
        Deleted = 2
    }

    public enum ScheduleStatus
    {
        None = 0,
        Schedule = 1,
        Chartered = 2,
        Maintainance = 3,
    }

    public enum CalendarType
    {
        None = 0,
        Daily = 1,
        Weekly = 2,
        Monthly = 3,
    }

    public enum AWBNumberStatus
    {
        None= 0,
        All = 1,
        Avilable = 2,
        Used = 3
    }

    public enum CargoAgentStatus
    {
        None = 0,
        Pending = 1,
        Active = 2,
        Suspended = 3
    }

    public enum NotificationType
    {
        None = 0,
        Booking_Made = 1,
        AWB_Added = 2,
        Cargo_Received = 3,
        Off_Loaded = 4,
        Flight_Dispatched = 5,
        Flight_Arrived = 6,
        Cargo_AssignedTo_New_Flight = 8,
        Cancelled = 7

    }

    public enum CargoType
    {
        None = 0,
        General = 1,
        DGR=2
    }

    public enum RateType {
        None = 0,
        SpotRate =1,
        PromotionalRate=2,
        ContractRate=3,
        MarketPublishRate=4
    }

    public enum UploadStorageType
    {
        None = 0,
        Blob = 1
    }

    public enum UserRole
    {
        None = 0,
        [Description("Booking Admin")]
        BookingAdmin =1,
        [Description("Backoffice Admin")]
        BackofficeAdmin = 2,
        [Description("Warehouse Admin")]
        WarehouseAdmin = 3,
        [Description("Booking User")]
        BookingUser = 4,
        [Description("Backoffice User")]
        BackofficeUser = 5,
        [Description("Warehouse User")]
        WarehouseUser = 6
    }

    public enum AccessPortalLevel
    {
        None = 0,
        Booking = 1,
        Backoffice = 2,
        WareHouse = 3
    }

    public enum UserStatus
    {
        None = 0,
        Pending = 1, // not new password created. still autogenerated.
        Active = 2,
        Suspended = 3
    }

}