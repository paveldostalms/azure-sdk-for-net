// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.KubernetesConfiguration.Samples
{
    public partial class Sample_KubernetesSourceControlConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSourceControlConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetSourceControlConfiguration.json
            // this example is just showing the usage of "SourceControlConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubernetesSourceControlConfigurationResource created on azure
            // for more information of creating KubernetesSourceControlConfigurationResource, please refer to the document of KubernetesSourceControlConfigurationResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            string sourceControlConfigurationName = "SRS_GitHubConfig";
            ResourceIdentifier kubernetesSourceControlConfigurationResourceId = KubernetesSourceControlConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterRp, clusterResourceName, clusterName, sourceControlConfigurationName);
            KubernetesSourceControlConfigurationResource kubernetesSourceControlConfiguration = client.GetKubernetesSourceControlConfigurationResource(kubernetesSourceControlConfigurationResourceId);

            // invoke the operation
            KubernetesSourceControlConfigurationResource result = await kubernetesSourceControlConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesSourceControlConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSourceControlConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/DeleteSourceControlConfiguration.json
            // this example is just showing the usage of "SourceControlConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubernetesSourceControlConfigurationResource created on azure
            // for more information of creating KubernetesSourceControlConfigurationResource, please refer to the document of KubernetesSourceControlConfigurationResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            string sourceControlConfigurationName = "SRS_GitHubConfig";
            ResourceIdentifier kubernetesSourceControlConfigurationResourceId = KubernetesSourceControlConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterRp, clusterResourceName, clusterName, sourceControlConfigurationName);
            KubernetesSourceControlConfigurationResource kubernetesSourceControlConfiguration = client.GetKubernetesSourceControlConfigurationResource(kubernetesSourceControlConfigurationResourceId);

            // invoke the operation
            await kubernetesSourceControlConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateSourceControlConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/CreateSourceControlConfiguration.json
            // this example is just showing the usage of "SourceControlConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubernetesSourceControlConfigurationResource created on azure
            // for more information of creating KubernetesSourceControlConfigurationResource, please refer to the document of KubernetesSourceControlConfigurationResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            string sourceControlConfigurationName = "SRS_GitHubConfig";
            ResourceIdentifier kubernetesSourceControlConfigurationResourceId = KubernetesSourceControlConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterRp, clusterResourceName, clusterName, sourceControlConfigurationName);
            KubernetesSourceControlConfigurationResource kubernetesSourceControlConfiguration = client.GetKubernetesSourceControlConfigurationResource(kubernetesSourceControlConfigurationResourceId);

            // invoke the operation
            KubernetesSourceControlConfigurationData data = new KubernetesSourceControlConfigurationData
            {
                RepositoryUri = new Uri("git@github.com:k8sdeveloper425/flux-get-started"),
                OperatorNamespace = "SRS_Namespace",
                OperatorInstanceName = "SRSGitHubFluxOp-01",
                OperatorType = KubernetesOperator.Flux,
                OperatorParams = "--git-email=xyzgituser@users.srs.github.com",
                ConfigurationProtectedSettings =
{
["protectedSetting1Key"] = "protectedSetting1Value"
},
                OperatorScope = KubernetesOperatorScope.Namespace,
                SshKnownHostsContents = "c3NoLmRldi5henVyZS5jb20gc3NoLXJzYSBBQUFBQjNOemFDMXljMkVBQUFBREFRQUJBQUFCQVFDN0hyMW9UV3FOcU9sekdKT2ZHSjROYWtWeUl6ZjFyWFlkNGQ3d282akJsa0x2Q0E0b2RCbEwwbURVeVowL1FVZlRUcWV1K3RtMjJnT3N2K1ZyVlRNazZ2d1JVNzVnWS95OXV0NU1iM2JSNUJWNThkS1h5cTlBOVVlQjVDYWtlaG41WmdtNngxbUtvVnlmK0ZGbjI2aVlxWEpSZ3pJWlpjWjVWNmhyRTBRZzM5a1ptNGF6NDhvMEFVYmY2U3A0U0xkdm51TWEyc1ZOd0hCYm9TN0VKa201N1hRUFZVMy9RcHlOTEhiV0Rkend0cmxTK2V6MzBTM0FkWWhMS0VPeEFHOHdlT255cnRMSkFVZW45bVRrb2w4b0lJMWVkZjdtV1diV1ZmMG5CbWx5MjErblpjbUNUSVNRQnRkY3lQYUVubzdmRlFNREQyNi9zMGxmS29iNEt3OEg=",
                IsHelmOperatorEnabled = true,
                HelmOperatorProperties = new HelmOperatorProperties
                {
                    ChartVersion = "0.3.0",
                    ChartValues = "--set git.ssh.secretName=flux-git-deploy --set tillerNamespace=kube-system",
                },
            };
            ArmOperation<KubernetesSourceControlConfigurationResource> lro = await kubernetesSourceControlConfiguration.UpdateAsync(WaitUntil.Completed, data);
            KubernetesSourceControlConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesSourceControlConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
