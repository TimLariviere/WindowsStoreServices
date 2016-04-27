using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStoreServices.V1.Common
{
    public abstract class OrderedQuery<TOrderByFields> : Query
    {
        public string ApplicationId { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.MinValue;
        public DateTime? EndDate { get; set; } = DateTime.MaxValue;
        public int? Top { get; set; }
        public int? Skip { get; set; }
        public string Filter { get; set; }
        public AggregationLevels? AggregationLevel { get; set; }
        public List<Tuple<TOrderByFields, OrderByDirections>> OrderBy { get; set; }

        public override string GetUri()
        {
            var sb = new StringBuilder();

            sb.Append($"{Uri}?applicationId={ApplicationId}");

            if (StartDate.HasValue)
                sb.Append($"&startDate={StartDate.Value.ToString("MM/dd/yyyy")}");

            if (EndDate.HasValue)
                sb.Append($"&endDate={EndDate.Value.ToString("MM/dd/yyyy")}");

            if (Top.HasValue)
                sb.Append($"&top={Top.Value}");

            if (Skip.HasValue)
                sb.Append($"&skip={Skip.Value}");

            if (!string.IsNullOrEmpty(Filter))
                sb.Append($"&filter={Filter}");

            if (AggregationLevel.HasValue)
                sb.Append($"&aggregationLevel={AggregationLevel.Value.AsString()}");

            if (OrderBy != null && OrderBy.Any())
            {
                var value = string.Join(",", OrderBy.Select(o => $"{o.Item1.AsString()} {o.Item2.AsString()}"));
                sb.Append($"orderBy={value}");
            }

            return sb.ToString();
        }
    }
}
