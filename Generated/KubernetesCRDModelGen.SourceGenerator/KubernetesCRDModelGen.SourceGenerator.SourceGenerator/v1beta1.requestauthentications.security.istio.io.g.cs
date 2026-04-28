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
public partial class V1beta1RequestAuthenticationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RequestAuthentication>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RequestAuthenticationList";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "requestauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.istio.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RequestAuthenticationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RequestAuthentication objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RequestAuthentication> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpecJwtRulesFromHeaders
{
    /// <summary>The HTTP header name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The prefix that should be stripped before decoding the token.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpecJwtRulesOutputClaimToHeaders
{
    /// <summary>The name of the claim to be copied from.</summary>
    [JsonPropertyName("claim")]
    public required string Claim { get; set; }

    /// <summary>The name of the header to be created.</summary>
    [JsonPropertyName("header")]
    public required string Header { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpecJwtRules
{
    /// <summary>The list of JWT [audiences](https://tools.ietf.org/html/rfc7519#section-4.1.3) that are allowed to access.</summary>
    [JsonPropertyName("audiences")]
    public IList<string>? Audiences { get; set; }

    /// <summary>If set to true, the original token will be kept for the upstream request.</summary>
    [JsonPropertyName("forwardOriginalToken")]
    public bool? ForwardOriginalToken { get; set; }

    /// <summary>List of cookie names from which JWT is expected.</summary>
    [JsonPropertyName("fromCookies")]
    public IList<string>? FromCookies { get; set; }

    /// <summary>List of header locations from which JWT is expected.</summary>
    [JsonPropertyName("fromHeaders")]
    public IList<V1beta1RequestAuthenticationSpecJwtRulesFromHeaders>? FromHeaders { get; set; }

    /// <summary>List of query parameters from which JWT is expected.</summary>
    [JsonPropertyName("fromParams")]
    public IList<string>? FromParams { get; set; }

    /// <summary>Identifies the issuer that issued the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set of public keys to validate signature of the JWT.</summary>
    [JsonPropertyName("jwks")]
    public string? Jwks { get; set; }

    /// <summary>URL of the provider&apos;s public key set to validate signature of the JWT.</summary>
    [JsonPropertyName("jwks_uri")]
    public string? JwksUri { get; set; }

    /// <summary>URL of the provider&apos;s public key set to validate signature of the JWT.</summary>
    [JsonPropertyName("jwksUri1")]
    public string? JwksUri1 { get; set; }

    /// <summary>This field specifies a list of operations to copy the claim to HTTP headers on a successfully verified token.</summary>
    [JsonPropertyName("outputClaimToHeaders")]
    public IList<V1beta1RequestAuthenticationSpecJwtRulesOutputClaimToHeaders>? OutputClaimToHeaders { get; set; }

    /// <summary>This field specifies the header name to output a successfully verified JWT payload to the backend.</summary>
    [JsonPropertyName("outputPayloadToHeader")]
    public string? OutputPayloadToHeader { get; set; }

    /// <summary>List of JWT claim names that should be treated as space-delimited strings.</summary>
    [JsonPropertyName("spaceDelimitedClaims")]
    public IList<string>? SpaceDelimitedClaims { get; set; }

    /// <summary>The maximum amount of time that the resolver, determined by the PILOT_JWT_ENABLE_REMOTE_JWKS environment variable, will spend waiting for the JWKS to be fetched.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpecTargetRef
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
public partial class V1beta1RequestAuthenticationSpecTargetRefs
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

/// <summary>Request authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/request_authentication.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RequestAuthenticationSpec
{
    /// <summary>Define the list of JWTs that can be validated at the selected workloads&apos; proxy.</summary>
    [JsonPropertyName("jwtRules")]
    public IList<V1beta1RequestAuthenticationSpecJwtRules>? JwtRules { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1beta1RequestAuthenticationSpecSelector? Selector { get; set; }

    [JsonPropertyName("targetRef")]
    public V1beta1RequestAuthenticationSpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1beta1RequestAuthenticationSpecTargetRefs>? TargetRefs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RequestAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RequestAuthenticationSpec?>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RequestAuthentication";
    public const string KubeGroup = "security.istio.io";
    public const string KubePluralName = "requestauthentications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.istio.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RequestAuthentication";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Request authentication configuration for workloads. See more details at: https://istio.io/docs/reference/config/security/request_authentication.html</summary>
    [JsonPropertyName("spec")]
    public V1beta1RequestAuthenticationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}