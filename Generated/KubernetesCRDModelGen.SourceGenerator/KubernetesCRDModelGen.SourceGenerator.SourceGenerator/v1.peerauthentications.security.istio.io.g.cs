#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.istio.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1PeerAuthenticationList : IKubernetesObject<V1ListMeta>, IItems<V1PeerAuthentication>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "PeerAuthenticationList";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "peerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.istio.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PeerAuthenticationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1PeerAuthentication objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1PeerAuthentication> Items { get; set; }
}

/// <summary>
/// Defines the mTLS mode used for peer authentication.
/// 
/// Valid Options: DISABLE, PERMISSIVE, STRICT
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PeerAuthenticationSpecMtlsModeEnum>))]
public enum V1PeerAuthenticationSpecMtlsModeEnum
{
    [EnumMember(Value = "UNSET"), JsonStringEnumMemberName("UNSET")]
    UNSET,
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "PERMISSIVE"), JsonStringEnumMemberName("PERMISSIVE")]
    PERMISSIVE,
    [EnumMember(Value = "STRICT"), JsonStringEnumMemberName("STRICT")]
    STRICT
}

/// <summary>Mutual TLS settings for workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PeerAuthenticationSpecMtls
{
    /// <summary>
    /// Defines the mTLS mode used for peer authentication.
    /// 
    /// Valid Options: DISABLE, PERMISSIVE, STRICT
    /// </summary>
    [JsonPropertyName("mode")]
    public V1PeerAuthenticationSpecMtlsModeEnum? Mode { get; set; }
}

/// <summary>
/// Defines the mTLS mode used for peer authentication.
/// 
/// Valid Options: DISABLE, PERMISSIVE, STRICT
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PeerAuthenticationSpecPortLevelMtlsModeEnum>))]
public enum V1PeerAuthenticationSpecPortLevelMtlsModeEnum
{
    [EnumMember(Value = "UNSET"), JsonStringEnumMemberName("UNSET")]
    UNSET,
    [EnumMember(Value = "DISABLE"), JsonStringEnumMemberName("DISABLE")]
    DISABLE,
    [EnumMember(Value = "PERMISSIVE"), JsonStringEnumMemberName("PERMISSIVE")]
    PERMISSIVE,
    [EnumMember(Value = "STRICT"), JsonStringEnumMemberName("STRICT")]
    STRICT
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PeerAuthenticationSpecPortLevelMtls
{
    /// <summary>
    /// Defines the mTLS mode used for peer authentication.
    /// 
    /// Valid Options: DISABLE, PERMISSIVE, STRICT
    /// </summary>
    [JsonPropertyName("mode")]
    public V1PeerAuthenticationSpecPortLevelMtlsModeEnum? Mode { get; set; }
}

/// <summary>The selector determines the workloads to apply the PeerAuthentication on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PeerAuthenticationSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Peer authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/peer_authentication.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PeerAuthenticationSpec
{
    /// <summary>Mutual TLS settings for workload.</summary>
    [JsonPropertyName("mtls")]
    public V1PeerAuthenticationSpecMtls? Mtls { get; set; }

    /// <summary>Port specific mutual TLS settings.</summary>
    [JsonPropertyName("portLevelMtls")]
    public IDictionary<string, V1PeerAuthenticationSpecPortLevelMtls>? PortLevelMtls { get; set; }

    /// <summary>The selector determines the workloads to apply the PeerAuthentication on.</summary>
    [JsonPropertyName("selector")]
    public V1PeerAuthenticationSpecSelector? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1PeerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1PeerAuthenticationSpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "PeerAuthentication";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "peerauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.istio.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PeerAuthentication";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Peer authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/peer_authentication.html</summary>
    [JsonPropertyName("spec")]
    public V1PeerAuthenticationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}