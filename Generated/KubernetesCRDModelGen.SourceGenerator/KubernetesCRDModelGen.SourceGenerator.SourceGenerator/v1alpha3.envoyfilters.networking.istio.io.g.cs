#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3EnvoyFilterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha3EnvoyFilter>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "EnvoyFilterList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "envoyfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvoyFilterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha3EnvoyFilter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha3EnvoyFilter> Items { get; set; }
}

/// <summary>
/// Specifies where in the Envoy configuration, the patch should be applied.
/// 
/// Valid Options: LISTENER, FILTER_CHAIN, NETWORK_FILTER, HTTP_FILTER, ROUTE_CONFIGURATION, VIRTUAL_HOST, HTTP_ROUTE, CLUSTER, EXTENSION_CONFIG, BOOTSTRAP, LISTENER_FILTER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum>))]
public enum V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum
{
    [EnumMember(Value = "INVALID"), JsonStringEnumMemberName("INVALID")]
    INVALID,
    [EnumMember(Value = "LISTENER"), JsonStringEnumMemberName("LISTENER")]
    LISTENER,
    [EnumMember(Value = "FILTER_CHAIN"), JsonStringEnumMemberName("FILTER_CHAIN")]
    FILTERCHAIN,
    [EnumMember(Value = "NETWORK_FILTER"), JsonStringEnumMemberName("NETWORK_FILTER")]
    NETWORKFILTER,
    [EnumMember(Value = "HTTP_FILTER"), JsonStringEnumMemberName("HTTP_FILTER")]
    HTTPFILTER,
    [EnumMember(Value = "ROUTE_CONFIGURATION"), JsonStringEnumMemberName("ROUTE_CONFIGURATION")]
    ROUTECONFIGURATION,
    [EnumMember(Value = "VIRTUAL_HOST"), JsonStringEnumMemberName("VIRTUAL_HOST")]
    VIRTUALHOST,
    [EnumMember(Value = "HTTP_ROUTE"), JsonStringEnumMemberName("HTTP_ROUTE")]
    HTTPROUTE,
    [EnumMember(Value = "CLUSTER"), JsonStringEnumMemberName("CLUSTER")]
    CLUSTER,
    [EnumMember(Value = "EXTENSION_CONFIG"), JsonStringEnumMemberName("EXTENSION_CONFIG")]
    EXTENSIONCONFIG,
    [EnumMember(Value = "BOOTSTRAP"), JsonStringEnumMemberName("BOOTSTRAP")]
    BOOTSTRAP,
    [EnumMember(Value = "LISTENER_FILTER"), JsonStringEnumMemberName("LISTENER_FILTER")]
    LISTENERFILTER
}

/// <summary>Match on envoy cluster attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchCluster
{
    /// <summary>The exact name of the cluster to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service port for which this cluster was generated.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }

    /// <summary>The fully qualified service name for this cluster.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The subset associated with the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

/// <summary>
/// The specific config generation context to match on.
/// 
/// Valid Options: ANY, SIDECAR_INBOUND, SIDECAR_OUTBOUND, GATEWAY, WAYPOINT
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum>))]
public enum V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum
{
    [EnumMember(Value = "ANY"), JsonStringEnumMemberName("ANY")]
    ANY,
    [EnumMember(Value = "SIDECAR_INBOUND"), JsonStringEnumMemberName("SIDECAR_INBOUND")]
    SIDECARINBOUND,
    [EnumMember(Value = "SIDECAR_OUTBOUND"), JsonStringEnumMemberName("SIDECAR_OUTBOUND")]
    SIDECAROUTBOUND,
    [EnumMember(Value = "GATEWAY"), JsonStringEnumMemberName("GATEWAY")]
    GATEWAY,
    [EnumMember(Value = "WAYPOINT"), JsonStringEnumMemberName("WAYPOINT")]
    WAYPOINT
}

/// <summary>The next level filter within this filter to match upon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilterSubFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The name of a specific filter to apply the patch to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next level filter within this filter to match upon.</summary>
    [JsonPropertyName("subFilter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilterSubFilter? SubFilter { get; set; }
}

/// <summary>Match a specific filter chain in a listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChain
{
    /// <summary>Applies only to sidecars.</summary>
    [JsonPropertyName("applicationProtocols")]
    public string? ApplicationProtocols { get; set; }

    /// <summary>The destination_port value used by a filter chain&apos;s match condition.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>The name of a specific filter to apply the patch to.</summary>
    [JsonPropertyName("filter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilter? Filter { get; set; }

    /// <summary>The name assigned to the filter chain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SNI value used by a filter chain&apos;s match condition.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>Applies only to `SIDECAR_INBOUND` context.</summary>
    [JsonPropertyName("transportProtocol")]
    public string? TransportProtocol { get; set; }
}

/// <summary>Match on envoy listener attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListener
{
    /// <summary>Match a specific filter chain in a listener.</summary>
    [JsonPropertyName("filterChain")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChain? FilterChain { get; set; }

    /// <summary>Match a specific listener filter.</summary>
    [JsonPropertyName("listenerFilter")]
    public string? ListenerFilter { get; set; }

    /// <summary>Match a specific listener by its name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The service port/gateway port to which traffic is being sent/received.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }
}

/// <summary>Match on properties associated with a proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchProxy
{
    /// <summary>Match on the node metadata supplied by a proxy when connecting to istiod.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>A regular expression in golang regex format (RE2) that can be used to select proxies using a specific version of istio proxy.</summary>
    [JsonPropertyName("proxyVersion")]
    public string? ProxyVersion { get; set; }
}

/// <summary>
/// Match a route with specific action type.
/// 
/// Valid Options: ANY, ROUTE, REDIRECT, DIRECT_RESPONSE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum>))]
public enum V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum
{
    [EnumMember(Value = "ANY"), JsonStringEnumMemberName("ANY")]
    ANY,
    [EnumMember(Value = "ROUTE"), JsonStringEnumMemberName("ROUTE")]
    ROUTE,
    [EnumMember(Value = "REDIRECT"), JsonStringEnumMemberName("REDIRECT")]
    REDIRECT,
    [EnumMember(Value = "DIRECT_RESPONSE"), JsonStringEnumMemberName("DIRECT_RESPONSE")]
    DIRECTRESPONSE
}

/// <summary>Match a specific route within the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute
{
    /// <summary>
    /// Match a route with specific action type.
    /// 
    /// Valid Options: ANY, ROUTE, REDIRECT, DIRECT_RESPONSE
    /// </summary>
    [JsonPropertyName("action")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum? Action { get; set; }

    /// <summary>The Route objects generated by default are named as default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Match a specific virtual host in a route configuration and apply the patch to the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhost
{
    /// <summary>Match a domain name in a virtual host.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The VirtualHosts objects generated by Istio are named as host:port, where the host typically corresponds to the VirtualService&apos;s host field or the hostname of a service in the registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Match a specific route within the virtual host.</summary>
    [JsonPropertyName("route")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute? Route { get; set; }
}

/// <summary>Match on envoy HTTP route configuration attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfiguration
{
    /// <summary>The Istio gateway config&apos;s namespace/name for which this route configuration was generated.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Route configuration name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Applicable only for GATEWAY context.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The service port number or gateway server port number for which this route configuration was generated.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }

    /// <summary>Match a specific virtual host in a route configuration and apply the patch to the virtual host.</summary>
    [JsonPropertyName("vhost")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhost? Vhost { get; set; }
}

/// <summary>The next level filter within this filter to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointFilterSubFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The name of a specific filter to apply the patch to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next level filter within this filter to match on.</summary>
    [JsonPropertyName("subFilter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointFilterSubFilter? SubFilter { get; set; }
}

/// <summary>Match a specific route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointRoute
{
    /// <summary>The Route objects generated by default are named as default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypoint
{
    /// <summary>The name of a specific filter to apply the patch to.</summary>
    [JsonPropertyName("filter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointFilter? Filter { get; set; }

    /// <summary>The service port to match on.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }

    /// <summary>Match a specific route.</summary>
    [JsonPropertyName("route")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypointRoute? Route { get; set; }
}

/// <summary>Match on listener/route configuration/cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatch
{
    /// <summary>Match on envoy cluster attributes.</summary>
    [JsonPropertyName("cluster")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchCluster? Cluster { get; set; }

    /// <summary>
    /// The specific config generation context to match on.
    /// 
    /// Valid Options: ANY, SIDECAR_INBOUND, SIDECAR_OUTBOUND, GATEWAY, WAYPOINT
    /// </summary>
    [JsonPropertyName("context")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum? Context { get; set; }

    /// <summary>Match on envoy listener attributes.</summary>
    [JsonPropertyName("listener")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListener? Listener { get; set; }

    /// <summary>Match on properties associated with a proxy.</summary>
    [JsonPropertyName("proxy")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchProxy? Proxy { get; set; }

    /// <summary>Match on envoy HTTP route configuration attributes.</summary>
    [JsonPropertyName("routeConfiguration")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfiguration? RouteConfiguration { get; set; }

    [JsonPropertyName("waypoint")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchWaypoint? Waypoint { get; set; }
}

/// <summary>
/// Determines the filter insertion order.
/// 
/// Valid Options: AUTHN, AUTHZ, STATS
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum>))]
public enum V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "AUTHN"), JsonStringEnumMemberName("AUTHN")]
    AUTHN,
    [EnumMember(Value = "AUTHZ"), JsonStringEnumMemberName("AUTHZ")]
    AUTHZ,
    [EnumMember(Value = "STATS"), JsonStringEnumMemberName("STATS")]
    STATS
}

/// <summary>
/// Determines how the patch should be applied.
/// 
/// Valid Options: MERGE, ADD, REMOVE, INSERT_BEFORE, INSERT_AFTER, INSERT_FIRST, REPLACE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum>))]
public enum V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum
{
    [EnumMember(Value = "INVALID"), JsonStringEnumMemberName("INVALID")]
    INVALID,
    [EnumMember(Value = "MERGE"), JsonStringEnumMemberName("MERGE")]
    MERGE,
    [EnumMember(Value = "ADD"), JsonStringEnumMemberName("ADD")]
    ADD,
    [EnumMember(Value = "REMOVE"), JsonStringEnumMemberName("REMOVE")]
    REMOVE,
    [EnumMember(Value = "INSERT_BEFORE"), JsonStringEnumMemberName("INSERT_BEFORE")]
    INSERTBEFORE,
    [EnumMember(Value = "INSERT_AFTER"), JsonStringEnumMemberName("INSERT_AFTER")]
    INSERTAFTER,
    [EnumMember(Value = "INSERT_FIRST"), JsonStringEnumMemberName("INSERT_FIRST")]
    INSERTFIRST,
    [EnumMember(Value = "REPLACE"), JsonStringEnumMemberName("REPLACE")]
    REPLACE
}

/// <summary>The patch to apply along with the operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesPatch
{
    /// <summary>
    /// Determines the filter insertion order.
    /// 
    /// Valid Options: AUTHN, AUTHZ, STATS
    /// </summary>
    [JsonPropertyName("filterClass")]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum? FilterClass { get; set; }

    /// <summary>
    /// Determines how the patch should be applied.
    /// 
    /// Valid Options: MERGE, ADD, REMOVE, INSERT_BEFORE, INSERT_AFTER, INSERT_FIRST, REPLACE
    /// </summary>
    [JsonPropertyName("operation")]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum? Operation { get; set; }

    /// <summary>The JSON config of the object being patched.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatches
{
    /// <summary>
    /// Specifies where in the Envoy configuration, the patch should be applied.
    /// 
    /// Valid Options: LISTENER, FILTER_CHAIN, NETWORK_FILTER, HTTP_FILTER, ROUTE_CONFIGURATION, VIRTUAL_HOST, HTTP_ROUTE, CLUSTER, EXTENSION_CONFIG, BOOTSTRAP, LISTENER_FILTER
    /// </summary>
    [JsonPropertyName("applyTo")]
    public V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum? ApplyTo { get; set; }

    /// <summary>Match on listener/route configuration/cluster.</summary>
    [JsonPropertyName("match")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatch? Match { get; set; }

    /// <summary>The patch to apply along with the operation.</summary>
    [JsonPropertyName("patch")]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatch? Patch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecTargetRefs
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this patch configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Customizing Envoy configuration generated by Istio. See more details at: https://istio.io/docs/reference/config/networking/envoy-filter.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpec
{
    /// <summary>One or more patches with match conditions.</summary>
    [JsonPropertyName("configPatches")]
    public IList<V1alpha3EnvoyFilterSpecConfigPatches>? ConfigPatches { get; set; }

    /// <summary>Priority defines the order in which patch sets are applied within a context.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha3EnvoyFilterSpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this patch configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1alpha3EnvoyFilterSpecWorkloadSelector? WorkloadSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3EnvoyFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha3EnvoyFilterSpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "EnvoyFilter";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "envoyfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvoyFilter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Customizing Envoy configuration generated by Istio. See more details at: https://istio.io/docs/reference/config/networking/envoy-filter.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha3EnvoyFilterSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}