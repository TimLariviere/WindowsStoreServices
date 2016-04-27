using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.ErrorReportingData
{
    public enum ErrorReportingDataGroupBy
    {
        [EnumMember(Value = "date")]
        Date,
            
        [EnumMember(Value = "applicationId")]
        ApplicationId,
            
        [EnumMember(Value = "applicationName")]
        ApplicationName,
            
        [EnumMember(Value = "deviceCount")]
        DeviceCount,
            
        [EnumMember(Value = "eventCount")]
        EventCount
    }
}
