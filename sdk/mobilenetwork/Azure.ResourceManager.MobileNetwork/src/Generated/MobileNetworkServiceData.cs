// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkService data model.
    /// Service resource. Must be created in the same location as its parent mobile network.
    /// </summary>
    public partial class MobileNetworkServiceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="servicePrecedence"> A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all services configured in the mobile network. </param>
        /// <param name="pccRules"> The set of data flow policy rules that make up this service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pccRules"/> is null. </exception>
        public MobileNetworkServiceData(AzureLocation location, int servicePrecedence, IEnumerable<PccRuleConfiguration> pccRules) : base(location)
        {
            Argument.AssertNotNull(pccRules, nameof(pccRules));

            ServicePrecedence = servicePrecedence;
            PccRules = pccRules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the service resource. </param>
        /// <param name="servicePrecedence"> A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all services configured in the mobile network. </param>
        /// <param name="serviceQosPolicy"> The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy field in a PccRuleConfiguration. If this field is null then the UE's SIM policy will define the QoS settings. </param>
        /// <param name="pccRules"> The set of data flow policy rules that make up this service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkProvisioningState? provisioningState, int servicePrecedence, MobileNetworkQosPolicy serviceQosPolicy, IList<PccRuleConfiguration> pccRules, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            ServicePrecedence = servicePrecedence;
            ServiceQosPolicy = serviceQosPolicy;
            PccRules = pccRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkServiceData"/> for deserialization. </summary>
        internal MobileNetworkServiceData()
        {
        }

        /// <summary> The provisioning state of the service resource. </summary>
        [WirePath("properties.provisioningState")]
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A precedence value that is used to decide between services when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all services configured in the mobile network. </summary>
        [WirePath("properties.servicePrecedence")]
        public int ServicePrecedence { get; set; }
        /// <summary> The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy field in a PccRuleConfiguration. If this field is null then the UE's SIM policy will define the QoS settings. </summary>
        [WirePath("properties.serviceQosPolicy")]
        public MobileNetworkQosPolicy ServiceQosPolicy { get; set; }
        /// <summary> The set of data flow policy rules that make up this service. </summary>
        [WirePath("properties.pccRules")]
        public IList<PccRuleConfiguration> PccRules { get; }
    }
}
