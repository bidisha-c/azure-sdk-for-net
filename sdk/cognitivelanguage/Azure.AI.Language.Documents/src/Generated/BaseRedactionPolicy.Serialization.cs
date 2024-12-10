// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Documents
{
    [PersistableModelProxy(typeof(UnknownBaseRedactionPolicy))]
    public partial class BaseRedactionPolicy : IUtf8JsonSerializable, IJsonModel<BaseRedactionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BaseRedactionPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BaseRedactionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseRedactionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseRedactionPolicy)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("policyKind"u8);
            writer.WriteStringValue(PolicyKind.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BaseRedactionPolicy IJsonModel<BaseRedactionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseRedactionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BaseRedactionPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBaseRedactionPolicy(document.RootElement, options);
        }

        internal static BaseRedactionPolicy DeserializeBaseRedactionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("policyKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "characterMask": return CharacterMaskPolicy.DeserializeCharacterMaskPolicy(element, options);
                    case "entityMask": return EntityMaskPolicy.DeserializeEntityMaskPolicy(element, options);
                    case "noMask": return NoMaskPolicy.DeserializeNoMaskPolicy(element, options);
                }
            }
            return UnknownBaseRedactionPolicy.DeserializeUnknownBaseRedactionPolicy(element, options);
        }

        BinaryData IPersistableModel<BaseRedactionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseRedactionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BaseRedactionPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        BaseRedactionPolicy IPersistableModel<BaseRedactionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BaseRedactionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBaseRedactionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BaseRedactionPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BaseRedactionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BaseRedactionPolicy FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBaseRedactionPolicy(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
