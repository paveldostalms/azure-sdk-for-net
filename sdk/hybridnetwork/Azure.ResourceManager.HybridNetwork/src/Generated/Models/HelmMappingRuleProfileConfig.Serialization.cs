// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmMappingRuleProfileConfig : IUtf8JsonSerializable, IJsonModel<HelmMappingRuleProfileConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmMappingRuleProfileConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HelmMappingRuleProfileConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(InstallOptions))
            {
                writer.WritePropertyName("installOptions"u8);
                writer.WriteObjectValue(InstallOptions, options);
            }
            if (Optional.IsDefined(UpgradeOptions))
            {
                writer.WritePropertyName("upgradeOptions"u8);
                writer.WriteObjectValue(UpgradeOptions, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        HelmMappingRuleProfileConfig IJsonModel<HelmMappingRuleProfileConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
        }

        internal static HelmMappingRuleProfileConfig DeserializeHelmMappingRuleProfileConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HelmInstallConfig installOptions = default;
            HelmUpgradeConfig upgradeOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("installOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installOptions = HelmInstallConfig.DeserializeHelmInstallConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("upgradeOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeOptions = HelmUpgradeConfig.DeserializeHelmUpgradeConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HelmMappingRuleProfileConfig(installOptions, upgradeOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmMappingRuleProfileConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support writing '{options.Format}' format.");
            }
        }

        HelmMappingRuleProfileConfig IPersistableModel<HelmMappingRuleProfileConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmMappingRuleProfileConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
