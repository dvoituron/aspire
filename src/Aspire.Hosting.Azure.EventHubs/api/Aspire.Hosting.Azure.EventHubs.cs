//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class AzureEventHubsExtensions
    {
        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> AddAzureEventHubs(this IDistributedApplicationBuilder builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubConsumerGroupResource> AddConsumerGroup(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubResource> builder, string name, string? groupName = null) { throw null; }

        [System.Obsolete("This method is obsolete because it has the wrong return type and will be removed in a future version. Use AddHub instead to add an Azure Event Hub.")]
        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> AddEventHub(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubResource> AddHub(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> builder, string name, string? hubName = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> RunAsEmulator(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsResource> builder, System.Action<ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource>>? configureContainer = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithConfiguration(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, System.Action<System.Text.Json.Nodes.JsonNode> configJson) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithConfigurationFile(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, string path) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithDataBindMount(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, string? path = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithDataVolume(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, string? name = null) { throw null; }

        [System.Obsolete("Use WithHostPort instead.")]
        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithGatewayPort(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, int? port) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> WithHostPort(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubsEmulatorResource> builder, int? port) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureEventHubResource> WithProperties(this ApplicationModel.IResourceBuilder<Azure.AzureEventHubResource> builder, System.Action<Azure.AzureEventHubResource> configure) { throw null; }
    }
}

namespace Aspire.Hosting.Azure
{
    public partial class AzureEventHubConsumerGroupResource : ApplicationModel.Resource, ApplicationModel.IResourceWithParent<AzureEventHubResource>, ApplicationModel.IResourceWithParent, ApplicationModel.IResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzureEventHubConsumerGroupResource(string name, string consumerGroupName, AzureEventHubResource parent) : base(default!) { }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public string ConsumerGroupName { get { throw null; } set { } }

        public AzureEventHubResource Parent { get { throw null; } }
    }

    public partial class AzureEventHubResource : ApplicationModel.Resource, ApplicationModel.IResourceWithParent<AzureEventHubsResource>, ApplicationModel.IResourceWithParent, ApplicationModel.IResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzureEventHubResource(string name, string hubName, AzureEventHubsResource parent) : base(default!) { }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public string HubName { get { throw null; } set { } }

        public AzureEventHubsResource Parent { get { throw null; } }

        public long? PartitionCount { get { throw null; } set { } }
    }

    public partial class AzureEventHubsEmulatorResource : ApplicationModel.ContainerResource, ApplicationModel.IResource
    {
        public AzureEventHubsEmulatorResource(AzureEventHubsResource innerResource) : base(default!, default) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public override string Name { get { throw null; } }
    }

    public partial class AzureEventHubsResource : AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences, ApplicationModel.IResourceWithEndpoints, IResourceWithAzureFunctionsConfig
    {
        public AzureEventHubsResource(string name, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public BicepOutputReference EventHubsEndpoint { get { throw null; } }

        public bool IsEmulator { get { throw null; } }

        void IResourceWithAzureFunctionsConfig.ApplyAzureFunctionsConfiguration(System.Collections.Generic.IDictionary<string, object> target, string connectionName) { }
    }
}