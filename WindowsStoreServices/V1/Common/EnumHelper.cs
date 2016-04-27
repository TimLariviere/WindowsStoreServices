using System.Reflection;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common
{
    public static class EnumHelper
    {
        public static string AsString<T>(this T enumValue)
        {
            var result = enumValue.ToString();

            var enumType = typeof(AggregationLevels);
            var enumMemberAttribute = enumType.GetRuntimeField(result).GetCustomAttribute<EnumMemberAttribute>();
            if (enumMemberAttribute != null)
            {
                result = enumMemberAttribute.Value;
            }

            return result;
        }
    }
}
