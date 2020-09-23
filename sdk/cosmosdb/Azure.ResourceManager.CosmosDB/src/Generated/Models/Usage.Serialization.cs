// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class Usage
    {
        internal static Usage DeserializeUsage(JsonElement element)
        {
            Optional<UnitType> unit = default;
            Optional<MetricName> name = default;
            Optional<string> quotaPeriod = default;
            Optional<long> limit = default;
            Optional<long> currentValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    unit = new UnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = MetricName.DeserializeMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("quotaPeriod"))
                {
                    quotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    currentValue = property.Value.GetInt64();
                    continue;
                }
            }
            return new Usage(Optional.ToNullable(unit), name.Value, quotaPeriod.Value, Optional.ToNullable(limit), Optional.ToNullable(currentValue));
        }
    }
}