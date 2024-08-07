// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.TimeZone.Models
{
    public partial class TimeZoneWindows
    {
        internal static TimeZoneWindows DeserializeTimeZoneWindows(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string windowsId = default;
            string territory = default;
            IReadOnlyList<string> ianaIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("WindowsId"u8))
                {
                    windowsId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Territory"u8))
                {
                    territory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IanaIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ianaIds = array;
                    continue;
                }
            }
            return new TimeZoneWindows(windowsId, territory, ianaIds ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TimeZoneWindows FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTimeZoneWindows(document.RootElement);
        }
    }
}
