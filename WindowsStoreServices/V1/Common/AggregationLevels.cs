using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common
{
    public enum AggregationLevels
    {
        [EnumMember(Value = "day")]
        Day,

        [EnumMember(Value = "week")]
        Week,

        [EnumMember(Value = "month")]
        Month
    }
}
