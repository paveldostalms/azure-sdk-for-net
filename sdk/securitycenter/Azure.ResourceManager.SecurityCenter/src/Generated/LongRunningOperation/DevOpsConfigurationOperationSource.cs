// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter
{
    internal class DevOpsConfigurationOperationSource : IOperationSource<DevOpsConfigurationResource>
    {
        private readonly ArmClient _client;

        internal DevOpsConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevOpsConfigurationResource IOperationSource<DevOpsConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevOpsConfigurationData>(response.Content);
            return new DevOpsConfigurationResource(_client, data);
        }

        async ValueTask<DevOpsConfigurationResource> IOperationSource<DevOpsConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevOpsConfigurationData>(response.Content);
            return await Task.FromResult(new DevOpsConfigurationResource(_client, data)).ConfigureAwait(false);
        }
    }
}
