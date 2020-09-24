// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcssmsDeliveryReportReceivedEventData
    {
        internal static AcssmsDeliveryReportReceivedEventData DeserializeAcssmsDeliveryReportReceivedEventData(JsonElement element)
        {
            Optional<string> deliveryStatus = default;
            Optional<string> deliveryStatusDetails = default;
            Optional<IReadOnlyList<AcssmsDeliveryAttemptProperties>> deliveryAttempts = default;
            Optional<DateTimeOffset> receivedTimestamp = default;
            Optional<string> messageId = default;
            Optional<string> @from = default;
            Optional<string> to = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deliveryStatus"))
                {
                    deliveryStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deliveryStatusDetails"))
                {
                    deliveryStatusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deliveryAttempts"))
                {
                    List<AcssmsDeliveryAttemptProperties> array = new List<AcssmsDeliveryAttemptProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcssmsDeliveryAttemptProperties.DeserializeAcssmsDeliveryAttemptProperties(item));
                    }
                    deliveryAttempts = array;
                    continue;
                }
                if (property.NameEquals("receivedTimestamp"))
                {
                    receivedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("messageId"))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("from"))
                {
                    @from = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"))
                {
                    to = property.Value.GetString();
                    continue;
                }
            }
            return new AcssmsDeliveryReportReceivedEventData(messageId.Value, @from.Value, to.Value, deliveryStatus.Value, deliveryStatusDetails.Value, Optional.ToList(deliveryAttempts), Optional.ToNullable(receivedTimestamp));
        }
    }
}