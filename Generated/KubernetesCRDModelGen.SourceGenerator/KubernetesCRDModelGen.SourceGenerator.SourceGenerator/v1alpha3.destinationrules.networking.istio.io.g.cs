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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3DestinationRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha3DestinationRule>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "DestinationRuleList";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "destinationrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DestinationRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha3DestinationRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha3DestinationRule> Items { get; set; }
}

/// <summary>
/// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
/// 
/// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp
{
    /// <summary>
    /// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
    /// 
    /// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
    /// </summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookieAttributes
{
    /// <summary>The name of the cookie attribute.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The optional value of the cookie attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Additional attributes for the cookie.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookieAttributes>? Attributes { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, &apos;/&apos; separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the &apos;from&apos; region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>
/// 
/// 
/// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    LEASTREQUEST
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer
{
    [JsonPropertyName("consistentHash")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    [JsonPropertyName("localityLbSetting")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>
    /// 
    /// 
    /// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
    /// </summary>
    [JsonPropertyName("simple")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>
/// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
/// 
/// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>
    /// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
    /// 
    /// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
    /// </summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookieAttributes
{
    /// <summary>The name of the cookie attribute.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The optional value of the cookie attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Additional attributes for the cookie.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookieAttributes>? Attributes { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, &apos;/&apos; separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the &apos;from&apos; region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>
/// 
/// 
/// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    LEASTREQUEST
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer
{
    [JsonPropertyName("consistentHash")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    [JsonPropertyName("localityLbSetting")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>
    /// 
    /// 
    /// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
    /// </summary>
    [JsonPropertyName("simple")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>
/// Indicates whether connections to this port should be secured using TLS.
/// 
/// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>
    /// Indicates whether connections to this port should be secured using TLS.
    /// 
    /// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTlsModeEnum? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings
{
    [JsonPropertyName("connectionPool")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("outlierDetection")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

/// <summary>
/// The PROXY protocol version to use.
/// 
/// Valid Options: V1, V2
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>The upstream PROXY protocol settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol
{
    /// <summary>
    /// The PROXY protocol version to use.
    /// 
    /// Valid Options: V1, V2
    /// </summary>
    [JsonPropertyName("version")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyProxyProtocolVersionEnum? Version { get; set; }
}

/// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyRetryBudget
{
    /// <summary>Specifies the minimum retry concurrency allowed for the retry budget.</summary>
    [JsonPropertyName("minRetryConcurrency")]
    public int? MinRetryConcurrency { get; set; }

    /// <summary>Specifies the limit on concurrent retries as a percentage of the sum of active requests and active pending requests.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Indicates whether connections to this port should be secured using TLS.
/// 
/// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum>))]
public enum V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>
    /// Indicates whether connections to this port should be secured using TLS.
    /// 
    /// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTlsModeEnum? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTunnel
{
    /// <summary>Specifies which protocol to use for tunneling the downstream connection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a host to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetHost")]
    public required string TargetHost { get; set; }

    /// <summary>Specifies a port to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetPort")]
    public required int TargetPort { get; set; }
}

/// <summary>Traffic policies that apply to this subset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsetsTrafficPolicy
{
    [JsonPropertyName("connectionPool")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("outlierDetection")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1alpha3DestinationRuleSpecSubsetsTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
    [JsonPropertyName("retryBudget")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyRetryBudget? RetryBudget { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicyTunnel? Tunnel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecSubsets
{
    /// <summary>Labels apply a filter over the endpoints of a service in the service registry.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Name of the subset.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Traffic policies that apply to this subset.</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1alpha3DestinationRuleSpecSubsetsTrafficPolicy? TrafficPolicy { get; set; }
}

/// <summary>
/// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
/// 
/// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolHttp
{
    /// <summary>
    /// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
    /// 
    /// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
    /// </summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha3DestinationRuleSpecTrafficPolicyConnectionPoolTcp? Tcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookieAttributes
{
    /// <summary>The name of the cookie attribute.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The optional value of the cookie attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Additional attributes for the cookie.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookieAttributes>? Attributes { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, &apos;/&apos; separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the &apos;from&apos; region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>
/// 
/// 
/// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    LEASTREQUEST
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancer
{
    [JsonPropertyName("consistentHash")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerConsistentHash? ConsistentHash { get; set; }

    [JsonPropertyName("localityLbSetting")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>
    /// 
    /// 
    /// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
    /// </summary>
    [JsonPropertyName("simple")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>
/// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
/// 
/// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "DO_NOT_UPGRADE"), JsonStringEnumMemberName("DO_NOT_UPGRADE")]
    DONOTUPGRADE,
    [EnumMember(Value = "UPGRADE"), JsonStringEnumMemberName("UPGRADE")]
    UPGRADE
}

/// <summary>HTTP connection pool settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp
{
    /// <summary>
    /// Specify if http1.1 connection should be upgraded to http2 for the associated destination.
    /// 
    /// Valid Options: DEFAULT, DO_NOT_UPGRADE, UPGRADE
    /// </summary>
    [JsonPropertyName("h2UpgradePolicy")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttpH2UpgradePolicyEnum? H2UpgradePolicy { get; set; }

    /// <summary>Maximum number of requests that will be queued while waiting for a ready connection pool connection.</summary>
    [JsonPropertyName("http1MaxPendingRequests")]
    public int? Http1MaxPendingRequests { get; set; }

    /// <summary>Maximum number of active requests to a destination.</summary>
    [JsonPropertyName("http2MaxRequests")]
    public int? Http2MaxRequests { get; set; }

    /// <summary>The idle timeout for upstream connection pool connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum number of concurrent streams allowed for a peer on one HTTP/2 connection.</summary>
    [JsonPropertyName("maxConcurrentStreams")]
    public int? MaxConcurrentStreams { get; set; }

    /// <summary>Maximum number of requests per connection to a backend.</summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public int? MaxRequestsPerConnection { get; set; }

    /// <summary>Maximum number of retries that can be outstanding to all hosts in a cluster at a given time.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>If set to true, client protocol will be preserved while initiating connection to backend.</summary>
    [JsonPropertyName("useClientProtocol")]
    public bool? UseClientProtocol { get; set; }
}

/// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive
{
    /// <summary>The time duration between keep-alive probes.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum number of keepalive probes to send without response before deciding the connection is dead.</summary>
    [JsonPropertyName("probes")]
    public int? Probes { get; set; }

    /// <summary>The time duration a connection needs to be idle before keep-alive probes start being sent.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp
{
    /// <summary>TCP connection timeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The idle timeout for TCP connections.</summary>
    [JsonPropertyName("idleTimeout")]
    public string? IdleTimeout { get; set; }

    /// <summary>The maximum duration of a connection.</summary>
    [JsonPropertyName("maxConnectionDuration")]
    public string? MaxConnectionDuration { get; set; }

    /// <summary>Maximum number of HTTP1 /TCP connections to a destination host.</summary>
    [JsonPropertyName("maxConnections")]
    public int? MaxConnections { get; set; }

    /// <summary>If set then set SO_KEEPALIVE on the socket to enable TCP Keepalives.</summary>
    [JsonPropertyName("tcpKeepalive")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcpTcpKeepalive? TcpKeepalive { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool
{
    /// <summary>HTTP connection pool settings.</summary>
    [JsonPropertyName("http")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolHttp? Http { get; set; }

    /// <summary>Settings common to both HTTP and TCP upstream connections.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPoolTcp? Tcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookieAttributes
{
    /// <summary>The name of the cookie attribute.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The optional value of the cookie attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Hash based on HTTP cookie.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie
{
    /// <summary>Additional attributes for the cookie.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookieAttributes>? Attributes { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Lifetime of the cookie.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev
{
    /// <summary>The table size for Maglev hashing.</summary>
    [JsonPropertyName("tableSize")]
    public int? TableSize { get; set; }
}

/// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash
{
    /// <summary>The minimum number of virtual nodes to use for the hash ring.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash
{
    /// <summary>Hash based on HTTP cookie.</summary>
    [JsonPropertyName("httpCookie")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>Hash based on a specific HTTP header.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>Hash based on a specific HTTP query parameter.</summary>
    [JsonPropertyName("httpQueryParameterName")]
    public string? HttpQueryParameterName { get; set; }

    /// <summary>The Maglev load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("maglev")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashMaglev? Maglev { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("minimumRingSize")]
    public int? MinimumRingSize { get; set; }

    /// <summary>The ring/modulo hash load balancer implements consistent hashing to backend hosts.</summary>
    [JsonPropertyName("ringHash")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHashRingHash? RingHash { get; set; }

    /// <summary>Hash based on the source IP address.</summary>
    [JsonPropertyName("useSourceIp")]
    public bool? UseSourceIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute
{
    /// <summary>Originating locality, &apos;/&apos; separated, e.g.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Map of upstream localities to traffic distribution weights.</summary>
    [JsonPropertyName("to")]
    public IDictionary<string, int>? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover
{
    /// <summary>Originating region.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>Destination region the traffic will fail over to when endpoints in the &apos;from&apos; region becomes unhealthy.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting
{
    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("distribute")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingDistribute>? Distribute { get; set; }

    /// <summary>Enable locality load balancing.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional: only one of distribute, failover or failoverPriority can be set.</summary>
    [JsonPropertyName("failover")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSettingFailover>? Failover { get; set; }

    /// <summary>failoverPriority is an ordered list of labels used to sort endpoints to do priority based load balancing.</summary>
    [JsonPropertyName("failoverPriority")]
    public IList<string>? FailoverPriority { get; set; }
}

/// <summary>
/// 
/// 
/// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    UNSPECIFIED,
    [EnumMember(Value = "LEAST_CONN"), JsonStringEnumMemberName("LEAST_CONN")]
    LEASTCONN,
    [EnumMember(Value = "RANDOM"), JsonStringEnumMemberName("RANDOM")]
    RANDOM,
    [EnumMember(Value = "PASSTHROUGH"), JsonStringEnumMemberName("PASSTHROUGH")]
    PASSTHROUGH,
    [EnumMember(Value = "ROUND_ROBIN"), JsonStringEnumMemberName("ROUND_ROBIN")]
    ROUNDROBIN,
    [EnumMember(Value = "LEAST_REQUEST"), JsonStringEnumMemberName("LEAST_REQUEST")]
    LEASTREQUEST
}

/// <summary>Represents the warmup configuration of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerWarmup
{
    /// <summary>This parameter controls the speed of traffic increase over the warmup duration.</summary>
    [JsonPropertyName("aggression")]
    public double? Aggression { get; set; }

    [JsonPropertyName("duration")]
    public required string Duration { get; set; }

    [JsonPropertyName("minimumPercent")]
    public double? MinimumPercent { get; set; }
}

/// <summary>Settings controlling the load balancer algorithms.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer
{
    [JsonPropertyName("consistentHash")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerConsistentHash? ConsistentHash { get; set; }

    [JsonPropertyName("localityLbSetting")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerLocalityLbSetting? LocalityLbSetting { get; set; }

    /// <summary>
    /// 
    /// 
    /// Valid Options: LEAST_CONN, RANDOM, PASSTHROUGH, ROUND_ROBIN, LEAST_REQUEST
    /// </summary>
    [JsonPropertyName("simple")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerSimpleEnum? Simple { get; set; }

    /// <summary>Represents the warmup configuration of Service.</summary>
    [JsonPropertyName("warmup")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancerWarmup? Warmup { get; set; }

    /// <summary>Deprecated: use `warmup` instead.</summary>
    [JsonPropertyName("warmupDurationSecs")]
    public string? WarmupDurationSecs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection
{
    /// <summary>Minimum ejection duration.</summary>
    [JsonPropertyName("baseEjectionTime")]
    public string? BaseEjectionTime { get; set; }

    /// <summary>Number of 5xx errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutive5xxErrors")]
    public int? Consecutive5xxErrors { get; set; }

    [JsonPropertyName("consecutiveErrors")]
    public int? ConsecutiveErrors { get; set; }

    /// <summary>Number of gateway errors before a host is ejected from the connection pool.</summary>
    [JsonPropertyName("consecutiveGatewayErrors")]
    public int? ConsecutiveGatewayErrors { get; set; }

    /// <summary>The number of consecutive locally originated failures before ejection occurs.</summary>
    [JsonPropertyName("consecutiveLocalOriginFailures")]
    public int? ConsecutiveLocalOriginFailures { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Maximum % of hosts in the load balancing pool for the upstream service that can be ejected.</summary>
    [JsonPropertyName("maxEjectionPercent")]
    public int? MaxEjectionPercent { get; set; }

    /// <summary>Outlier detection will be enabled as long as the associated load balancing pool has at least `minHealthPercent` hosts in healthy mode.</summary>
    [JsonPropertyName("minHealthPercent")]
    public int? MinHealthPercent { get; set; }

    /// <summary>Determines whether to distinguish local origin failures from external errors.</summary>
    [JsonPropertyName("splitExternalLocalOriginErrors")]
    public bool? SplitExternalLocalOriginErrors { get; set; }
}

/// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsPort
{
    [JsonPropertyName("number")]
    public int? Number { get; set; }
}

/// <summary>
/// Indicates whether connections to this port should be secured using TLS.
/// 
/// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>
    /// Indicates whether connections to this port should be secured using TLS.
    /// 
    /// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsTlsModeEnum? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettings
{
    [JsonPropertyName("connectionPool")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("outlierDetection")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Specifies the number of a port on the destination service on which this policy is being applied.</summary>
    [JsonPropertyName("port")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsPort? Port { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettingsTls? Tls { get; set; }
}

/// <summary>
/// The PROXY protocol version to use.
/// 
/// Valid Options: V1, V2
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>The upstream PROXY protocol settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyProxyProtocol
{
    /// <summary>
    /// The PROXY protocol version to use.
    /// 
    /// Valid Options: V1, V2
    /// </summary>
    [JsonPropertyName("version")]
    public V1alpha3DestinationRuleSpecTrafficPolicyProxyProtocolVersionEnum? Version { get; set; }
}

/// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyRetryBudget
{
    /// <summary>Specifies the minimum retry concurrency allowed for the retry budget.</summary>
    [JsonPropertyName("minRetryConcurrency")]
    public int? MinRetryConcurrency { get; set; }

    /// <summary>Specifies the limit on concurrent retries as a percentage of the sum of active requests and active pending requests.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Indicates whether connections to this port should be secured using TLS.
/// 
/// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha3DestinationRuleSpecTrafficPolicyTlsModeEnum>))]
public enum V1alpha3DestinationRuleSpecTrafficPolicyTlsModeEnum
{
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "SIMPLE"), JsonStringEnumMemberName("SIMPLE")]
    SIMPLE,
    [EnumMember(Value = "MUTUAL"), JsonStringEnumMemberName("MUTUAL")]
    MUTUAL,
    [EnumMember(Value = "ISTIO_MUTUAL"), JsonStringEnumMemberName("ISTIO_MUTUAL")]
    ISTIOMUTUAL
}

/// <summary>TLS related settings for connections to the upstream service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyTls
{
    /// <summary>OPTIONAL: The path to the file containing certificate authority certificates to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCertificates")]
    public string? CaCertificates { get; set; }

    /// <summary>OPTIONAL: The path to the file containing the certificate revocation list (CRL) to use in verifying a presented server certificate.</summary>
    [JsonPropertyName("caCrl")]
    public string? CaCrl { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>The name of the secret that holds the TLS certs for the client including the CA certificates.</summary>
    [JsonPropertyName("credentialName")]
    public string? CredentialName { get; set; }

    /// <summary>`insecureSkipVerify` specifies whether the proxy should skip verifying the CA signature and SAN for the server certificate corresponding to the host.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>
    /// Indicates whether connections to this port should be secured using TLS.
    /// 
    /// Valid Options: DISABLE, SIMPLE, MUTUAL, ISTIO_MUTUAL
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha3DestinationRuleSpecTrafficPolicyTlsModeEnum? Mode { get; set; }

    /// <summary>REQUIRED if mode is `MUTUAL`.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>SNI string to present to the server during TLS handshake.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>A list of alternate names to verify the subject identity in the certificate.</summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicyTunnel
{
    /// <summary>Specifies which protocol to use for tunneling the downstream connection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a host to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetHost")]
    public required string TargetHost { get; set; }

    /// <summary>Specifies a port to which the downstream connection is tunneled.</summary>
    [JsonPropertyName("targetPort")]
    public required int TargetPort { get; set; }
}

/// <summary>Traffic policies to apply (load balancing policy, connection pool sizes, outlier detection).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecTrafficPolicy
{
    [JsonPropertyName("connectionPool")]
    public V1alpha3DestinationRuleSpecTrafficPolicyConnectionPool? ConnectionPool { get; set; }

    /// <summary>Settings controlling the load balancer algorithms.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1alpha3DestinationRuleSpecTrafficPolicyLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("outlierDetection")]
    public V1alpha3DestinationRuleSpecTrafficPolicyOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Traffic policies specific to individual ports.</summary>
    [JsonPropertyName("portLevelSettings")]
    public IList<V1alpha3DestinationRuleSpecTrafficPolicyPortLevelSettings>? PortLevelSettings { get; set; }

    /// <summary>The upstream PROXY protocol settings.</summary>
    [JsonPropertyName("proxyProtocol")]
    public V1alpha3DestinationRuleSpecTrafficPolicyProxyProtocol? ProxyProtocol { get; set; }

    /// <summary>Specifies a limit on concurrent retries in relation to the number of active requests.</summary>
    [JsonPropertyName("retryBudget")]
    public V1alpha3DestinationRuleSpecTrafficPolicyRetryBudget? RetryBudget { get; set; }

    /// <summary>TLS related settings for connections to the upstream service.</summary>
    [JsonPropertyName("tls")]
    public V1alpha3DestinationRuleSpecTrafficPolicyTls? Tls { get; set; }

    /// <summary>Configuration of tunneling TCP over other transport or application layers for the host configured in the DestinationRule.</summary>
    [JsonPropertyName("tunnel")]
    public V1alpha3DestinationRuleSpecTrafficPolicyTunnel? Tunnel { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Configuration affecting load balancing, outlier detection, etc. See more details at: https://istio.io/docs/reference/config/networking/destination-rule.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3DestinationRuleSpec
{
    /// <summary>A list of namespaces to which this destination rule is exported.</summary>
    [JsonPropertyName("exportTo")]
    public IList<string>? ExportTo { get; set; }

    /// <summary>The name of a service from the service registry.</summary>
    [JsonPropertyName("host")]
    public required string Host { get; set; }

    /// <summary>One or more named sets that represent individual versions of a service.</summary>
    [JsonPropertyName("subsets")]
    public IList<V1alpha3DestinationRuleSpecSubsets>? Subsets { get; set; }

    /// <summary>Traffic policies to apply (load balancing policy, connection pool sizes, outlier detection).</summary>
    [JsonPropertyName("trafficPolicy")]
    public V1alpha3DestinationRuleSpecTrafficPolicy? TrafficPolicy { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this `DestinationRule` configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1alpha3DestinationRuleSpecWorkloadSelector? WorkloadSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.3+0316f97acf12de380316633df08e7f13a064978d")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3DestinationRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha3DestinationRuleSpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "DestinationRule";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "destinationrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networking.istio.io/v1alpha3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DestinationRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Configuration affecting load balancing, outlier detection, etc. See more details at: https://istio.io/docs/reference/config/networking/destination-rule.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha3DestinationRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}