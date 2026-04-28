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
public partial class V1beta1VirtualServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualServiceList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "virtualservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VirtualService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VirtualService> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpCorsPolicyAllowOrigins
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>
/// Indicates whether preflight requests not matching the configured allowed origin shouldn&apos;t be forwarded to the upstream.
/// 
/// Valid Options: FORWARD, IGNORE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecHttpCorsPolicyUnmatchedPreflightsEnum>))]
public enum V1beta1VirtualServiceSpecHttpCorsPolicyUnmatchedPreflightsEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "FORWARD"), JsonStringEnumMemberName("FORWARD")]
    FORWARD,
    [EnumMember(Value = "IGNORE"), JsonStringEnumMemberName("IGNORE")]
    IGNORE
}

/// <summary>Cross-Origin Resource Sharing policy (CORS).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpCorsPolicy
{
    /// <summary>Indicates whether the caller is allowed to send the actual request (not the preflight) using credentials.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>List of HTTP headers that can be used when requesting the resource.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>List of HTTP methods allowed to access the resource.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    [JsonPropertyName("allowOrigin")]
    public IList<string>? AllowOrigin { get; set; }

    /// <summary>String patterns that match allowed origins.</summary>
    [JsonPropertyName("allowOrigins")]
    public IList<V1beta1VirtualServiceSpecHttpCorsPolicyAllowOrigins>? AllowOrigins { get; set; }

    /// <summary>A list of HTTP headers that the browsers are allowed to access.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>Specifies how long the results of a preflight request can be cached.</summary>
    [JsonPropertyName("maxAge")]
    public string? MaxAge { get; set; }

    /// <summary>
    /// Indicates whether preflight requests not matching the configured allowed origin shouldn&apos;t be forwarded to the upstream.
    /// 
    /// Valid Options: FORWARD, IGNORE
    /// </summary>
    [JsonPropertyName("unmatchedPreflights")]
    public V1beta1VirtualServiceSpecHttpCorsPolicyUnmatchedPreflightsEnum? UnmatchedPreflights { get; set; }
}

/// <summary>Delegate is used to specify the particular VirtualService which can be used to define delegate HTTPRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpDelegate
{
    /// <summary>Name specifies the name of the delegate VirtualService.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the namespace where the delegate VirtualService resides.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Specifies the content of the response body.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpDirectResponseBody
{
    /// <summary>response body as base64 encoded bytes.</summary>
    [JsonPropertyName("bytes")]
    public byte[]? Bytes { get; set; }

    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpDirectResponse
{
    /// <summary>Specifies the content of the response body.</summary>
    [JsonPropertyName("body")]
    public V1beta1VirtualServiceSpecHttpDirectResponseBody? Body { get; set; }

    /// <summary>Specifies the HTTP response status to be returned.</summary>
    [JsonPropertyName("status")]
    public required int Status { get; set; }
}

/// <summary>Percentage of requests to be aborted with the error code provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpFaultAbortPercentage
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Abort Http request attempts and return error codes back to downstream service, giving the impression that the upstream service is faulty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpFaultAbort
{
    /// <summary>GRPC status code to use to abort the request.</summary>
    [JsonPropertyName("grpcStatus")]
    public string? GrpcStatus { get; set; }

    [JsonPropertyName("http2Error")]
    public string? Http2Error { get; set; }

    /// <summary>HTTP status code to use to abort the Http request.</summary>
    [JsonPropertyName("httpStatus")]
    public int? HttpStatus { get; set; }

    /// <summary>Percentage of requests to be aborted with the error code provided.</summary>
    [JsonPropertyName("percentage")]
    public V1beta1VirtualServiceSpecHttpFaultAbortPercentage? Percentage { get; set; }
}

/// <summary>Percentage of requests on which the delay will be injected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpFaultDelayPercentage
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Delay requests before forwarding, emulating various failures such as network issues, overloaded upstream service, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpFaultDelay
{
    [JsonPropertyName("exponentialDelay")]
    public string? ExponentialDelay { get; set; }

    /// <summary>Add a fixed delay before forwarding the request.</summary>
    [JsonPropertyName("fixedDelay")]
    public string? FixedDelay { get; set; }

    /// <summary>Percentage of requests on which the delay will be injected (0-100).</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>Percentage of requests on which the delay will be injected.</summary>
    [JsonPropertyName("percentage")]
    public V1beta1VirtualServiceSpecHttpFaultDelayPercentage? Percentage { get; set; }
}

/// <summary>Fault injection policy to apply on HTTP traffic at the client side.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpFault
{
    /// <summary>Abort Http request attempts and return error codes back to downstream service, giving the impression that the upstream service is faulty.</summary>
    [JsonPropertyName("abort")]
    public V1beta1VirtualServiceSpecHttpFaultAbort? Abort { get; set; }

    /// <summary>Delay requests before forwarding, emulating various failures such as network issues, overloaded upstream service, etc.</summary>
    [JsonPropertyName("delay")]
    public V1beta1VirtualServiceSpecHttpFaultDelay? Delay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpHeadersRequest
{
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpHeadersResponse
{
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpHeaders
{
    [JsonPropertyName("request")]
    public V1beta1VirtualServiceSpecHttpHeadersRequest? Request { get; set; }

    [JsonPropertyName("response")]
    public V1beta1VirtualServiceSpecHttpHeadersResponse? Response { get; set; }
}

/// <summary>HTTP Authority values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchAuthority
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchHeaders
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>HTTP Method values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchMethod
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchQueryParams
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>URI Scheme values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchScheme
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>URI to match values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchUri
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatchWithoutHeaders
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMatch
{
    /// <summary>HTTP Authority values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("authority")]
    public V1beta1VirtualServiceSpecHttpMatchAuthority? Authority { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>The header keys must be lowercase and use hyphen as the separator, e.g.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, V1beta1VirtualServiceSpecHttpMatchHeaders>? Headers { get; set; }

    /// <summary>Flag to specify whether the URI matching should be case-insensitive.</summary>
    [JsonPropertyName("ignoreUriCase")]
    public bool? IgnoreUriCase { get; set; }

    /// <summary>HTTP Method values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("method")]
    public V1beta1VirtualServiceSpecHttpMatchMethod? Method { get; set; }

    /// <summary>The name assigned to a match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the ports on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Query parameters for matching.</summary>
    [JsonPropertyName("queryParams")]
    public IDictionary<string, V1beta1VirtualServiceSpecHttpMatchQueryParams>? QueryParams { get; set; }

    /// <summary>URI Scheme values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("scheme")]
    public V1beta1VirtualServiceSpecHttpMatchScheme? Scheme { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to source (client) workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }

    /// <summary>The human readable prefix to use when emitting statistics for this route.</summary>
    [JsonPropertyName("statPrefix")]
    public string? StatPrefix { get; set; }

    /// <summary>URI to match values are case-sensitive and formatted as follows: - `exact: &quot;value&quot;` for exact string match - `prefix: &quot;value&quot;` for prefix-based match - `regex: &quot;value&quot;` for [RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("uri")]
    public V1beta1VirtualServiceSpecHttpMatchUri? Uri { get; set; }

    /// <summary>withoutHeader has the same syntax with the header, but has opposite meaning.</summary>
    [JsonPropertyName("withoutHeaders")]
    public IDictionary<string, V1beta1VirtualServiceSpecHttpMatchWithoutHeaders>? WithoutHeaders { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrorPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>Mirror HTTP traffic to a another destination in addition to forwarding the requests to the intended destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirror
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1VirtualServiceSpecHttpMirrorPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

/// <summary>Percentage of the traffic to be mirrored by the `mirror` field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrorPercentage
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrorsDestinationPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>Destination specifies the target of the mirror operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrorsDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1VirtualServiceSpecHttpMirrorsDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

/// <summary>Percentage of the traffic to be mirrored by the `destination` field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrorsPercentage
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpMirrors
{
    /// <summary>Destination specifies the target of the mirror operation.</summary>
    [JsonPropertyName("destination")]
    public required V1beta1VirtualServiceSpecHttpMirrorsDestination Destination { get; set; }

    /// <summary>Percentage of the traffic to be mirrored by the `destination` field.</summary>
    [JsonPropertyName("percentage")]
    public V1beta1VirtualServiceSpecHttpMirrorsPercentage? Percentage { get; set; }
}

/// <summary>
/// On a redirect, dynamically set the port: * FROM_PROTOCOL_DEFAULT: automatically set to 80 for HTTP and 443 for HTTPS.
/// 
/// Valid Options: FROM_PROTOCOL_DEFAULT, FROM_REQUEST_PORT
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualServiceSpecHttpRedirectDerivePortEnum>))]
public enum V1beta1VirtualServiceSpecHttpRedirectDerivePortEnum
{
    [EnumMember(Value = "FROM_PROTOCOL_DEFAULT"), JsonStringEnumMemberName("FROM_PROTOCOL_DEFAULT")]
    FROMPROTOCOLDEFAULT,
    [EnumMember(Value = "FROM_REQUEST_PORT"), JsonStringEnumMemberName("FROM_REQUEST_PORT")]
    FROMREQUESTPORT
}

/// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRedirect
{
    /// <summary>On a redirect, overwrite the Authority/Host portion of the URL with this value.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>
    /// On a redirect, dynamically set the port: * FROM_PROTOCOL_DEFAULT: automatically set to 80 for HTTP and 443 for HTTPS.
    /// 
    /// Valid Options: FROM_PROTOCOL_DEFAULT, FROM_REQUEST_PORT
    /// </summary>
    [JsonPropertyName("derivePort")]
    public V1beta1VirtualServiceSpecHttpRedirectDerivePortEnum? DerivePort { get; set; }

    /// <summary>On a redirect, overwrite the port portion of the URL with this value.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>On a redirect, Specifies the HTTP status code to use in the redirect response.</summary>
    [JsonPropertyName("redirectCode")]
    public int? RedirectCode { get; set; }

    /// <summary>On a redirect, overwrite the scheme portion of the URL with this value.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>On a redirect, overwrite the Path portion of the URL with this value.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Retry policy for HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRetries
{
    /// <summary>Number of retries to be allowed for a given request.</summary>
    [JsonPropertyName("attempts")]
    public int? Attempts { get; set; }

    /// <summary>Specifies the minimum duration between retry attempts.</summary>
    [JsonPropertyName("backoff")]
    public string? Backoff { get; set; }

    /// <summary>Timeout per attempt for a given request, including the initial call and any retries.</summary>
    [JsonPropertyName("perTryTimeout")]
    public string? PerTryTimeout { get; set; }

    /// <summary>Flag to specify whether the retries should ignore previously tried hosts during retry.</summary>
    [JsonPropertyName("retryIgnorePreviousHosts")]
    public bool? RetryIgnorePreviousHosts { get; set; }

    /// <summary>Specifies the conditions under which retry takes place.</summary>
    [JsonPropertyName("retryOn")]
    public string? RetryOn { get; set; }

    /// <summary>Flag to specify whether the retries should retry to other localities.</summary>
    [JsonPropertyName("retryRemoteLocalities")]
    public bool? RetryRemoteLocalities { get; set; }
}

/// <summary>rewrite the path portion of the URI with the specified regex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRewriteUriRegexRewrite
{
    /// <summary>[RE2 style regex-based match](https://github.com/google/re2/wiki/Syntax).</summary>
    [JsonPropertyName("match")]
    public string? Match { get; set; }

    /// <summary>The string that should replace into matching portions of original URI.</summary>
    [JsonPropertyName("rewrite")]
    public string? Rewrite { get; set; }
}

/// <summary>Rewrite HTTP URIs and Authority headers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRewrite
{
    /// <summary>rewrite the Authority/Host header with this value.</summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>rewrite the path (or the prefix) portion of the URI with this value.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>rewrite the path portion of the URI with the specified regex.</summary>
    [JsonPropertyName("uriRegexRewrite")]
    public V1beta1VirtualServiceSpecHttpRewriteUriRegexRewrite? UriRegexRewrite { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRouteDestinationPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1VirtualServiceSpecHttpRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRouteHeadersRequest
{
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRouteHeadersResponse
{
    [JsonPropertyName("add")]
    public IDictionary<string, string>? Add { get; set; }

    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    [JsonPropertyName("set")]
    public IDictionary<string, string>? Set { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRouteHeaders
{
    [JsonPropertyName("request")]
    public V1beta1VirtualServiceSpecHttpRouteHeadersRequest? Request { get; set; }

    [JsonPropertyName("response")]
    public V1beta1VirtualServiceSpecHttpRouteHeadersResponse? Response { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttpRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public required V1beta1VirtualServiceSpecHttpRouteDestination Destination { get; set; }

    [JsonPropertyName("headers")]
    public V1beta1VirtualServiceSpecHttpRouteHeaders? Headers { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecHttp
{
    /// <summary>Cross-Origin Resource Sharing policy (CORS).</summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta1VirtualServiceSpecHttpCorsPolicy? CorsPolicy { get; set; }

    /// <summary>Delegate is used to specify the particular VirtualService which can be used to define delegate HTTPRoute.</summary>
    [JsonPropertyName("delegate")]
    public V1beta1VirtualServiceSpecHttpDelegate? Delegate { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("directResponse")]
    public V1beta1VirtualServiceSpecHttpDirectResponse? DirectResponse { get; set; }

    /// <summary>Fault injection policy to apply on HTTP traffic at the client side.</summary>
    [JsonPropertyName("fault")]
    public V1beta1VirtualServiceSpecHttpFault? Fault { get; set; }

    [JsonPropertyName("headers")]
    public V1beta1VirtualServiceSpecHttpHeaders? Headers { get; set; }

    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualServiceSpecHttpMatch>? Match { get; set; }

    /// <summary>Mirror HTTP traffic to a another destination in addition to forwarding the requests to the intended destination.</summary>
    [JsonPropertyName("mirror")]
    public V1beta1VirtualServiceSpecHttpMirror? Mirror { get; set; }

    [JsonPropertyName("mirror_percent")]
    public int? MirrorPercent { get; set; }

    [JsonPropertyName("mirrorPercent1")]
    public int? MirrorPercent1 { get; set; }

    /// <summary>Percentage of the traffic to be mirrored by the `mirror` field.</summary>
    [JsonPropertyName("mirrorPercentage")]
    public V1beta1VirtualServiceSpecHttpMirrorPercentage? MirrorPercentage { get; set; }

    /// <summary>Specifies the destinations to mirror HTTP traffic in addition to the original destination.</summary>
    [JsonPropertyName("mirrors")]
    public IList<V1beta1VirtualServiceSpecHttpMirrors>? Mirrors { get; set; }

    /// <summary>The name assigned to the route for debugging purposes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("redirect")]
    public V1beta1VirtualServiceSpecHttpRedirect? Redirect { get; set; }

    /// <summary>Retry policy for HTTP requests.</summary>
    [JsonPropertyName("retries")]
    public V1beta1VirtualServiceSpecHttpRetries? Retries { get; set; }

    /// <summary>Rewrite HTTP URIs and Authority headers.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1VirtualServiceSpecHttpRewrite? Rewrite { get; set; }

    /// <summary>A HTTP rule can either return a direct_response, redirect or forward (default) traffic.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualServiceSpecHttpRoute>? Route { get; set; }

    /// <summary>Timeout for HTTP requests, default is disabled.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTcpMatch
{
    /// <summary>IPv4 or IPv6 ip addresses of destination with optional subnet.</summary>
    [JsonPropertyName("destinationSubnets")]
    public IList<string>? DestinationSubnets { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }

    [JsonPropertyName("sourceSubnet")]
    public string? SourceSubnet { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTcpRouteDestinationPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTcpRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1VirtualServiceSpecTcpRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTcpRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public required V1beta1VirtualServiceSpecTcpRouteDestination Destination { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTcp
{
    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public IList<V1beta1VirtualServiceSpecTcpMatch>? Match { get; set; }

    /// <summary>The destination to which the connection should be forwarded to.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualServiceSpecTcpRoute>? Route { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTlsMatch
{
    /// <summary>IPv4 or IPv6 ip addresses of destination with optional subnet.</summary>
    [JsonPropertyName("destinationSubnets")]
    public IList<string>? DestinationSubnets { get; set; }

    /// <summary>Names of gateways where the rule should be applied.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>SNI (server name indicator) to match on.</summary>
    [JsonPropertyName("sniHosts")]
    public required IList<string> SniHosts { get; set; }

    /// <summary>One or more labels that constrain the applicability of a rule to workloads with the given labels.</summary>
    [JsonPropertyName("sourceLabels")]
    public IDictionary<string, string>? SourceLabels { get; set; }

    /// <summary>Source namespace constraining the applicability of a rule to workloads in that namespace.</summary>
    [JsonPropertyName("sourceNamespace")]
    public string? SourceNamespace { get; set; }
}

/// <summary>Specifies the port on the host that is being addressed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTlsRouteDestinationPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTlsRouteDestination
{
    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>Specifies the port on the host that is being addressed.</summary>
    [JsonPropertyName("port")]
    public V1beta1VirtualServiceSpecTlsRouteDestinationPort? Port { get; set; }

    /// <summary>The name of a subset within the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTlsRoute
{
    /// <summary>Destination uniquely identifies the instances of a service to which the request/connection should be forwarded to.</summary>
    [JsonPropertyName("destination")]
    public required V1beta1VirtualServiceSpecTlsRouteDestination Destination { get; set; }

    /// <summary>Weight specifies the relative proportion of traffic to be forwarded to the destination.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpecTls
{
    /// <summary>Match conditions to be satisfied for the rule to be activated.</summary>
    [JsonPropertyName("match")]
    public required IList<V1beta1VirtualServiceSpecTlsMatch> Match { get; set; }

    /// <summary>The destination to which the connection should be forwarded to.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta1VirtualServiceSpecTlsRoute>? Route { get; set; }
}

/// <summary>Configuration affecting label/content routing, sni routing, etc. See more details at: https://istio.io/docs/reference/config/networking/virtual-service.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualServiceSpec
{
    /// <summary>A list of namespaces to which this virtual service is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The names of gateways and sidecars that should apply these routes.</summary>
    [JsonPropertyName("gateways")]
    public IList<string>? Gateways { get; set; }

    /// <summary>The destination hosts to which traffic is being sent.</summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>An ordered list of route rules for HTTP traffic.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta1VirtualServiceSpecHttp>? Http { get; set; }

    /// <summary>An ordered list of route rules for opaque TCP traffic.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta1VirtualServiceSpecTcp>? Tcp { get; set; }

    /// <summary>An ordered list of route rule for non-terminated TLS &amp; HTTPS traffic.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1VirtualServiceSpecTls>? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualServiceSpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualService";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "virtualservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting label/content routing, sni routing, etc. See more details at: https://istio.io/docs/reference/config/networking/virtual-service.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualServiceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}