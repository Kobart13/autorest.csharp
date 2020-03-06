// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class OperationDisplay : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Provider != null)
            {
                writer.WritePropertyName("provider");
                writer.WriteStringValue(Provider);
            }
            if (Resource != null)
            {
                writer.WritePropertyName("resource");
                writer.WriteStringValue(Resource);
            }
            if (Operation != null)
            {
                writer.WritePropertyName("operation");
                writer.WriteStringValue(Operation);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }
        internal static OperationDisplay DeserializeOperationDisplay(JsonElement element)
        {
            OperationDisplay result = new OperationDisplay();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}