using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStoreServices.V1.Common
{
    public abstract class OrderedGroupedQuery<TOrderBy, TGroupBy> : OrderedQuery<TOrderBy>
    {
        public List<TGroupBy> GroupBy { get; set; }

        public override string GetUri()
        {
            var sb = new StringBuilder(base.GetUri());

            if (GroupBy != null && GroupBy.Any())
            {
                var value = string.Join(",", GroupBy.Select(s => s.AsString()));
                sb.Append($"&groupby={value}");
            }

            return sb.ToString();
        }
    }
}
