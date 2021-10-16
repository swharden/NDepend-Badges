using System;

namespace NDBadge
{
    public record Metric
    {
        public DateTime DateTime { get; init; }
        public string Name { get; init; }
        public string Unit { get; init; }
        public string Value { get; init; }
    }
}
