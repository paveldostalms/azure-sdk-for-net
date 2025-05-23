// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    public partial class SubmitHibernateContent : IUtf8JsonSerializable, IJsonModel<SubmitHibernateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubmitHibernateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SubmitHibernateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitHibernateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitHibernateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule, options);
            writer.WritePropertyName("executionParameters"u8);
            writer.WriteObjectValue(ExecutionParameters, options);
            writer.WritePropertyName("resources"u8);
            writer.WriteObjectValue(Resources, options);
            writer.WritePropertyName("correlationid"u8);
            writer.WriteStringValue(CorrelationId);
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

        SubmitHibernateContent IJsonModel<SubmitHibernateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitHibernateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubmitHibernateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubmitHibernateContent(document.RootElement, options);
        }

        internal static SubmitHibernateContent DeserializeSubmitHibernateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserRequestSchedule schedule = default;
            ScheduledActionExecutionParameterDetail executionParameters = default;
            UserRequestResources resources = default;
            string correlationid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = UserRequestSchedule.DeserializeUserRequestSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("executionParameters"u8))
                {
                    executionParameters = ScheduledActionExecutionParameterDetail.DeserializeScheduledActionExecutionParameterDetail(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    resources = UserRequestResources.DeserializeUserRequestResources(property.Value, options);
                    continue;
                }
                if (property.NameEquals("correlationid"u8))
                {
                    correlationid = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SubmitHibernateContent(schedule, executionParameters, resources, correlationid, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubmitHibernateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitHibernateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubmitHibernateContent)} does not support writing '{options.Format}' format.");
            }
        }

        SubmitHibernateContent IPersistableModel<SubmitHibernateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubmitHibernateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSubmitHibernateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubmitHibernateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubmitHibernateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
