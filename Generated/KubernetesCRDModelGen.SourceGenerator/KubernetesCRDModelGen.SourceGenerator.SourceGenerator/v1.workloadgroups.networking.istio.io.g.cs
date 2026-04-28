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
public partial class V1WorkloadGroupList : IKubernetesObject<V1ListMeta>, IItems<V1WorkloadGroup>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "WorkloadGroupList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "workloadgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1WorkloadGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1WorkloadGroup> Items { get; set; }
}

/// <summary>Metadata that will be used for all corresponding `WorkloadEntries`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Health is determined by how the command that is executed exited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbeExec
{
    /// <summary>Command to run.</summary>
    [JsonPropertyName("command")]
    public required IList<string> Command { get; set; }
}

/// <summary>GRPC call is made and response/error is used to determine health.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbeGrpc
{
    /// <summary>Port on which the endpoint lives.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbeHttpGetHttpHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>`httpGet` is performed to a given endpoint and the status/able to connect determines health.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbeHttpGet
{
    /// <summary>Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Headers the proxy will pass on to make the request.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1WorkloadGroupSpecProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port on which the endpoint lives.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Health is determined by if the proxy is able to connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbeTcpSocket
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public required int Port { get; set; }
}

/// <summary>`ReadinessProbe` describes the configuration the user must provide for healthchecking on their workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecProbe
{
    /// <summary>Health is determined by how the command that is executed exited.</summary>
    [JsonPropertyName("exec")]
    public V1WorkloadGroupSpecProbeExec? Exec { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>GRPC call is made and response/error is used to determine health.</summary>
    [JsonPropertyName("grpc")]
    public V1WorkloadGroupSpecProbeGrpc? Grpc { get; set; }

    /// <summary>`httpGet` is performed to a given endpoint and the status/able to connect determines health.</summary>
    [JsonPropertyName("httpGet")]
    public V1WorkloadGroupSpecProbeHttpGet? HttpGet { get; set; }

    /// <summary>Number of seconds after the container has started before readiness probes are initiated.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Health is determined by if the proxy is able to connect.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1WorkloadGroupSpecProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Number of seconds after which the probe times out.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Template to be used for the generation of `WorkloadEntry` resources that belong to this `WorkloadGroup`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpecTemplate
{
    /// <summary>Address associated with the network endpoint without the port.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>One or more labels associated with the endpoint.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The locality associated with the endpoint.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>Network enables Istio to group endpoints resident in the same L3 domain/network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Set of ports associated with the endpoint.</summary>
    [JsonPropertyName("ports")]
    public IDictionary<string, int>? Ports { get; set; }

    /// <summary>The service account associated with the workload if a sidecar is present in the workload.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The load balancing weight associated with the endpoint.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Describes a collection of workload instances. See more details at: https://istio.io/docs/reference/config/networking/workload-group.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1WorkloadGroupSpec
{
    /// <summary>Metadata that will be used for all corresponding `WorkloadEntries`.</summary>
    [JsonPropertyName("metadata")]
    public V1WorkloadGroupSpecMetadata? Metadata { get; set; }

    /// <summary>`ReadinessProbe` describes the configuration the user must provide for healthchecking on their workload.</summary>
    [JsonPropertyName("probe")]
    public V1WorkloadGroupSpecProbe? Probe { get; set; }

    /// <summary>Template to be used for the generation of `WorkloadEntry` resources that belong to this `WorkloadGroup`.</summary>
    [JsonPropertyName("template")]
    public required V1WorkloadGroupSpecTemplate Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1WorkloadGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1WorkloadGroupSpec>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "WorkloadGroup";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "workloadgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Describes a collection of workload instances. See more details at: https://istio.io/docs/reference/config/networking/workload-group.html</summary>
    [JsonPropertyName("spec")]
    public required V1WorkloadGroupSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}