using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Reviews
{
    public enum ReviewsOrderBy
    {
        [EnumMember(Value = "date")]
        Date,

        [EnumMember(Value = "osVersion")]
        OsVersion,

        [EnumMember(Value = "market")]
        Market,

        [EnumMember(Value = "deviceType")]
        DeviceType,

        [EnumMember(Value = "isRevised")]
        IsRevised,

        [EnumMember(Value = "packageVersion")]
        PackageVersion,

        [EnumMember(Value = "deviceModel")]
        DeviceModel,

        [EnumMember(Value = "productFamily")]
        ProductFamily,

        [EnumMember(Value = "deviceScreenResolution")]
        DeviceScreenResolution,

        [EnumMember(Value = "isTouchEnabled")]
        IsTouchEnabled,

        [EnumMember(Value = "reviewerName")]
        ReviewerName,

        [EnumMember(Value = "reviewTitle")]
        ReviewTitle,

        [EnumMember(Value = "reviewText")]
        ReviewText,

        [EnumMember(Value = "helpfulCount")]
        HelpfulCount,

        [EnumMember(Value = "notHelpfulCount")]
        NotHelpfulCount,

        [EnumMember(Value = "responseDate")]
        ResponseDate,

        [EnumMember(Value = "responseText")]
        ResponseText,

        [EnumMember(Value = "deviceRAM")]
        DeviceRAM,

        [EnumMember(Value = "deviceStorageCapacity")]
        DeviceStorageCapacity,

        [EnumMember(Value = "rating")]
        Rating
    }
}
