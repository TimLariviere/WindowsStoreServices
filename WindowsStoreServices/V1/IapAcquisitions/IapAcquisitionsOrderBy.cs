using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.IapAcquisitions
{
    public enum IapAcquisitionsOrderBy
    {
        [EnumMember(Value = "date")]
        Date,

        [EnumMember(Value = "acquisitionType")]
        AcquisitionType,

        [EnumMember(Value = "ageGroup")]
        AgeGroup,

        [EnumMember(Value = "storeClient")]
        StoreClient,

        [EnumMember(Value = "gender")]
        Gender,

        [EnumMember(Value = "market")]
        Market,

        [EnumMember(Value = "osVersion")]
        OsVersion,

        [EnumMember(Value = "deviceType")]
        DeviceType,

        [EnumMember(Value = "orderName")]
        OrderName
    }
}
