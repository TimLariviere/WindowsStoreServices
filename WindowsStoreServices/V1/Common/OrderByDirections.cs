using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common
{
    public enum OrderByDirections
    {
        [EnumMember(Value = "asc")]
        Ascending,

        [EnumMember(Value = "desc")]
        Descending
    }
}
