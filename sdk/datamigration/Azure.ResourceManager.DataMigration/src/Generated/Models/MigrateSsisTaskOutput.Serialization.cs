// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateSsisTaskOutput))]
    public partial class MigrateSsisTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateSsisTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSsisTaskOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSsisTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSsisTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSsisTaskOutput)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSsisTaskOutput IJsonModel<MigrateSsisTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSsisTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSsisTaskOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSsisTaskOutput(document.RootElement, options);
        }

        internal static MigrateSsisTaskOutput DeserializeMigrateSsisTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "MigrationLevelOutput": return MigrateSsisTaskOutputMigrationLevel.DeserializeMigrateSsisTaskOutputMigrationLevel(element, options);
                    case "SsisProjectLevelOutput": return MigrateSsisTaskOutputProjectLevel.DeserializeMigrateSsisTaskOutputProjectLevel(element, options);
                }
            }
            return UnknownMigrateSsisTaskOutput.DeserializeUnknownMigrateSsisTaskOutput(element, options);
        }

        BinaryData IPersistableModel<MigrateSsisTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSsisTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSsisTaskOutput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSsisTaskOutput IPersistableModel<MigrateSsisTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSsisTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMigrateSsisTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSsisTaskOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSsisTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
