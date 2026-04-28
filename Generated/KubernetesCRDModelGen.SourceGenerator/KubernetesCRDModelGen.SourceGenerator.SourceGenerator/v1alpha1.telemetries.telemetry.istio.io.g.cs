#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.telemetry.istio.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TelemetryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Telemetry>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TelemetryList";
    public const string KubeGroup = "telemetry.istio.io";
    public const string KubePluralName = "telemetries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "telemetry.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TelemetryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Telemetry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Telemetry> Items { get; set; }
}

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingFilter
{
    /// <summary>CEL expression for selecting when requests/connections should be logged.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>
/// This determines whether or not to apply the access logging configuration based on the direction of traffic relative to the proxied workload.
/// 
/// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TelemetrySpecAccessLoggingMatchModeEnum>))]
public enum V1alpha1TelemetrySpecAccessLoggingMatchModeEnum
{
    [EnumMember(Value = "CLIENT_AND_SERVER"), JsonStringEnumMemberName("CLIENT_AND_SERVER")]
    CLIENTANDSERVER,
    [EnumMember(Value = "CLIENT"), JsonStringEnumMemberName("CLIENT")]
    CLIENT,
    [EnumMember(Value = "SERVER"), JsonStringEnumMemberName("SERVER")]
    SERVER
}

/// <summary>Allows tailoring of logging behavior to specific conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingMatch
{
    /// <summary>
    /// This determines whether or not to apply the access logging configuration based on the direction of traffic relative to the proxied workload.
    /// 
    /// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha1TelemetrySpecAccessLoggingMatchModeEnum? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLoggingProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecAccessLogging
{
    /// <summary>Controls logging.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("filter")]
    public V1alpha1TelemetrySpecAccessLoggingFilter? Filter { get; set; }

    /// <summary>Allows tailoring of logging behavior to specific conditions.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecAccessLoggingMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecAccessLoggingProviders>? Providers { get; set; }
}

/// <summary>
/// One of the well-known [Istio Standard Metrics](https://istio.io/latest/docs/reference/config/metrics/).
/// 
/// Valid Options: ALL_METRICS, REQUEST_COUNT, REQUEST_DURATION, REQUEST_SIZE, RESPONSE_SIZE, TCP_OPENED_CONNECTIONS, TCP_CLOSED_CONNECTIONS, TCP_SENT_BYTES, TCP_RECEIVED_BYTES, GRPC_REQUEST_MESSAGES, GRPC_RESPONSE_MESSAGES
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TelemetrySpecMetricsOverridesMatchMetricEnum>))]
public enum V1alpha1TelemetrySpecMetricsOverridesMatchMetricEnum
{
    [EnumMember(Value = "ALL_METRICS"), JsonStringEnumMemberName("ALL_METRICS")]
    ALLMETRICS,
    [EnumMember(Value = "REQUEST_COUNT"), JsonStringEnumMemberName("REQUEST_COUNT")]
    REQUESTCOUNT,
    [EnumMember(Value = "REQUEST_DURATION"), JsonStringEnumMemberName("REQUEST_DURATION")]
    REQUESTDURATION,
    [EnumMember(Value = "REQUEST_SIZE"), JsonStringEnumMemberName("REQUEST_SIZE")]
    REQUESTSIZE,
    [EnumMember(Value = "RESPONSE_SIZE"), JsonStringEnumMemberName("RESPONSE_SIZE")]
    RESPONSESIZE,
    [EnumMember(Value = "TCP_OPENED_CONNECTIONS"), JsonStringEnumMemberName("TCP_OPENED_CONNECTIONS")]
    TCPOPENEDCONNECTIONS,
    [EnumMember(Value = "TCP_CLOSED_CONNECTIONS"), JsonStringEnumMemberName("TCP_CLOSED_CONNECTIONS")]
    TCPCLOSEDCONNECTIONS,
    [EnumMember(Value = "TCP_SENT_BYTES"), JsonStringEnumMemberName("TCP_SENT_BYTES")]
    TCPSENTBYTES,
    [EnumMember(Value = "TCP_RECEIVED_BYTES"), JsonStringEnumMemberName("TCP_RECEIVED_BYTES")]
    TCPRECEIVEDBYTES,
    [EnumMember(Value = "GRPC_REQUEST_MESSAGES"), JsonStringEnumMemberName("GRPC_REQUEST_MESSAGES")]
    GRPCREQUESTMESSAGES,
    [EnumMember(Value = "GRPC_RESPONSE_MESSAGES"), JsonStringEnumMemberName("GRPC_RESPONSE_MESSAGES")]
    GRPCRESPONSEMESSAGES
}

/// <summary>
/// Controls which mode of metrics generation is selected: `CLIENT`, `SERVER`, or `CLIENT_AND_SERVER`.
/// 
/// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TelemetrySpecMetricsOverridesMatchModeEnum>))]
public enum V1alpha1TelemetrySpecMetricsOverridesMatchModeEnum
{
    [EnumMember(Value = "CLIENT_AND_SERVER"), JsonStringEnumMemberName("CLIENT_AND_SERVER")]
    CLIENTANDSERVER,
    [EnumMember(Value = "CLIENT"), JsonStringEnumMemberName("CLIENT")]
    CLIENT,
    [EnumMember(Value = "SERVER"), JsonStringEnumMemberName("SERVER")]
    SERVER
}

/// <summary>Match allows providing the scope of the override.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverridesMatch
{
    /// <summary>Allows free-form specification of a metric.</summary>
    [JsonPropertyName("customMetric")]
    public string? CustomMetric { get; set; }

    /// <summary>
    /// One of the well-known [Istio Standard Metrics](https://istio.io/latest/docs/reference/config/metrics/).
    /// 
    /// Valid Options: ALL_METRICS, REQUEST_COUNT, REQUEST_DURATION, REQUEST_SIZE, RESPONSE_SIZE, TCP_OPENED_CONNECTIONS, TCP_CLOSED_CONNECTIONS, TCP_SENT_BYTES, TCP_RECEIVED_BYTES, GRPC_REQUEST_MESSAGES, GRPC_RESPONSE_MESSAGES
    /// </summary>
    [JsonPropertyName("metric")]
    public V1alpha1TelemetrySpecMetricsOverridesMatchMetricEnum? Metric { get; set; }

    /// <summary>
    /// Controls which mode of metrics generation is selected: `CLIENT`, `SERVER`, or `CLIENT_AND_SERVER`.
    /// 
    /// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha1TelemetrySpecMetricsOverridesMatchModeEnum? Mode { get; set; }
}

/// <summary>
/// Operation controls whether or not to update/add a tag, or to remove it.
/// 
/// Valid Options: UPSERT, REMOVE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TelemetrySpecMetricsOverridesTagOverridesOperationEnum>))]
public enum V1alpha1TelemetrySpecMetricsOverridesTagOverridesOperationEnum
{
    [EnumMember(Value = "UPSERT"), JsonStringEnumMemberName("UPSERT")]
    UPSERT,
    [EnumMember(Value = "REMOVE"), JsonStringEnumMemberName("REMOVE")]
    REMOVE
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverridesTagOverrides
{
    /// <summary>
    /// Operation controls whether or not to update/add a tag, or to remove it.
    /// 
    /// Valid Options: UPSERT, REMOVE
    /// </summary>
    [JsonPropertyName("operation")]
    public V1alpha1TelemetrySpecMetricsOverridesTagOverridesOperationEnum? Operation { get; set; }

    /// <summary>Value is only considered if the operation is `UPSERT`.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsOverrides
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Match allows providing the scope of the override.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecMetricsOverridesMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("tagOverrides")]
    public IDictionary<string, V1alpha1TelemetrySpecMetricsOverridesTagOverrides>? TagOverrides { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetricsProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecMetrics
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1alpha1TelemetrySpecMetricsOverrides>? Overrides { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecMetricsProviders>? Providers { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("reportingInterval")]
    public string? ReportingInterval { get; set; }
}

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTargetRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTargetRefs
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

/// <summary>Environment adds the value of an environment variable to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsEnvironment
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>Name of the environment variable from which to extract the tag value.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Formatter adds the value of access logging substitution formatter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsFormatter
{
    /// <summary>The formatter tag value to use, same formatter as HTTP access logging (e.g.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>RequestHeader adds the value of an header from the request to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsHeader
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>Name of the header from which to extract the tag value.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Literal adds the same, hard-coded value to each span.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTagsLiteral
{
    /// <summary>The tag value to use.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingCustomTags
{
    /// <summary>Environment adds the value of an environment variable to each span.</summary>
    [JsonPropertyName("environment")]
    public V1alpha1TelemetrySpecTracingCustomTagsEnvironment? Environment { get; set; }

    /// <summary>Formatter adds the value of access logging substitution formatter.</summary>
    [JsonPropertyName("formatter")]
    public V1alpha1TelemetrySpecTracingCustomTagsFormatter? Formatter { get; set; }

    /// <summary>RequestHeader adds the value of an header from the request to each span.</summary>
    [JsonPropertyName("header")]
    public V1alpha1TelemetrySpecTracingCustomTagsHeader? Header { get; set; }

    /// <summary>Literal adds the same, hard-coded value to each span.</summary>
    [JsonPropertyName("literal")]
    public V1alpha1TelemetrySpecTracingCustomTagsLiteral? Literal { get; set; }
}

/// <summary>
/// This determines whether or not to apply the tracing configuration based on the direction of traffic relative to the proxied workload.
/// 
/// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TelemetrySpecTracingMatchModeEnum>))]
public enum V1alpha1TelemetrySpecTracingMatchModeEnum
{
    [EnumMember(Value = "CLIENT_AND_SERVER"), JsonStringEnumMemberName("CLIENT_AND_SERVER")]
    CLIENTANDSERVER,
    [EnumMember(Value = "CLIENT"), JsonStringEnumMemberName("CLIENT")]
    CLIENT,
    [EnumMember(Value = "SERVER"), JsonStringEnumMemberName("SERVER")]
    SERVER
}

/// <summary>Allows tailoring of behavior to specific conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingMatch
{
    /// <summary>
    /// This determines whether or not to apply the tracing configuration based on the direction of traffic relative to the proxied workload.
    /// 
    /// Valid Options: CLIENT_AND_SERVER, CLIENT, SERVER
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha1TelemetrySpecTracingMatchModeEnum? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracingProviders
{
    /// <summary>Required.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpecTracing
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, V1alpha1TelemetrySpecTracingCustomTags>? CustomTags { get; set; }

    /// <summary>Controls span reporting.</summary>
    [JsonPropertyName("disableSpanReporting")]
    public bool? DisableSpanReporting { get; set; }

    /// <summary>Determines whether or not trace spans generated by Envoy will include Istio specific tags.</summary>
    [JsonPropertyName("enableIstioTags")]
    public bool? EnableIstioTags { get; set; }

    /// <summary>Allows tailoring of behavior to specific conditions.</summary>
    [JsonPropertyName("match")]
    public V1alpha1TelemetrySpecTracingMatch? Match { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("providers")]
    public IList<V1alpha1TelemetrySpecTracingProviders>? Providers { get; set; }

    /// <summary>Controls the rate at which traffic will be selected for tracing if no prior sampling decision has been made.</summary>
    [JsonPropertyName("randomSamplingPercentage")]
    public double? RandomSamplingPercentage { get; set; }

    [JsonPropertyName("useRequestIdForTraceSampling")]
    public bool? UseRequestIdForTraceSampling { get; set; }
}

/// <summary>Telemetry configuration for workloads. See more details at: https://istio.io/docs/reference/config/telemetry.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TelemetrySpec
{
    /// <summary>Optional.</summary>
    [JsonPropertyName("accessLogging")]
    public IList<V1alpha1TelemetrySpecAccessLogging>? AccessLogging { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1TelemetrySpecMetrics>? Metrics { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1TelemetrySpecSelector? Selector { get; set; }

    [JsonPropertyName("targetRef")]
    public V1alpha1TelemetrySpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1TelemetrySpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("tracing")]
    public IList<V1alpha1TelemetrySpecTracing>? Tracing { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Telemetry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TelemetrySpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Telemetry";
    public const string KubeGroup = "telemetry.istio.io";
    public const string KubePluralName = "telemetries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "telemetry.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Telemetry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Telemetry configuration for workloads. See more details at: https://istio.io/docs/reference/config/telemetry.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TelemetrySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}