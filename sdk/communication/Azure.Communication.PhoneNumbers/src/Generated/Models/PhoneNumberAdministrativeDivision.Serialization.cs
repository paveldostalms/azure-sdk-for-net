// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumberAdministrativeDivision
    {
        internal static PhoneNumberAdministrativeDivision DeserializePhoneNumberAdministrativeDivision(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string localizedName = default;
            string abbreviatedName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localizedName"u8))
                {
                    localizedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("abbreviatedName"u8))
                {
                    abbreviatedName = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberAdministrativeDivision(localizedName, abbreviatedName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PhoneNumberAdministrativeDivision FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePhoneNumberAdministrativeDivision(document.RootElement);
        }
    }
}
