#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.extensions.istio.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TrafficExtensionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TrafficExtension>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TrafficExtensionList";
    public const string KubeGroup = "extensions.istio.io";
    public const string KubePluralName = "trafficextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "extensions.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficExtensionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TrafficExtension objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TrafficExtension> Items { get; set; }
}

/// <summary>Lua filter configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecLua
{
    /// <summary>The inline Lua code to be executed.</summary>
    [JsonPropertyName("inlineCode")]
    public required string InlineCode { get; set; }
}

/// <summary>
/// Criteria for selecting traffic by their direction.
/// 
/// Valid Options: CLIENT, SERVER, CLIENT_AND_SERVER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecMatchModeEnum>))]
public enum V1alpha1TrafficExtensionSpecMatchModeEnum
{
    [EnumMember(Value = "UNDEFINED"), JsonStringEnumMemberName("UNDEFINED")]
    UNDEFINED,
    [EnumMember(Value = "CLIENT"), JsonStringEnumMemberName("CLIENT")]
    CLIENT,
    [EnumMember(Value = "SERVER"), JsonStringEnumMemberName("SERVER")]
    SERVER,
    [EnumMember(Value = "CLIENT_AND_SERVER"), JsonStringEnumMemberName("CLIENT_AND_SERVER")]
    CLIENTANDSERVER
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecMatchPorts
{
    [JsonPropertyName("number")]
    public required int Number { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecMatch
{
    /// <summary>
    /// Criteria for selecting traffic by their direction.
    /// 
    /// Valid Options: CLIENT, SERVER, CLIENT_AND_SERVER
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha1TrafficExtensionSpecMatchModeEnum? Mode { get; set; }

    /// <summary>Criteria for selecting traffic by their destination port.</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1TrafficExtensionSpecMatchPorts>? Ports { get; set; }
}

/// <summary>
/// Determines where in the filter chain this `TrafficExtension` is to be injected.
/// 
/// Valid Options: AUTHN, AUTHZ, STATS
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecPhaseEnum>))]
public enum V1alpha1TrafficExtensionSpecPhaseEnum
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

/// <summary>Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecTargetRefs
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

/// <summary>
/// Specifies the failure behavior for the plugin due to fatal errors.
/// 
/// Valid Options: FAIL_CLOSE, FAIL_OPEN, FAIL_RELOAD
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecWasmFailStrategyEnum>))]
public enum V1alpha1TrafficExtensionSpecWasmFailStrategyEnum
{
    [EnumMember(Value = "FAIL_CLOSE"), JsonStringEnumMemberName("FAIL_CLOSE")]
    FAILCLOSE,
    [EnumMember(Value = "FAIL_OPEN"), JsonStringEnumMemberName("FAIL_OPEN")]
    FAILOPEN,
    [EnumMember(Value = "FAIL_RELOAD"), JsonStringEnumMemberName("FAIL_RELOAD")]
    FAILRELOAD
}

/// <summary>
/// The pull behaviour to be applied when fetching Wasm module by either OCI image or `http/https`.
/// 
/// Valid Options: IfNotPresent, Always
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecWasmImagePullPolicyEnum>))]
public enum V1alpha1TrafficExtensionSpecWasmImagePullPolicyEnum
{
    [EnumMember(Value = "UNSPECIFIED_POLICY"), JsonStringEnumMemberName("UNSPECIFIED_POLICY")]
    UNSPECIFIEDPOLICY,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always
}

/// <summary>
/// Specifies the type of Wasm Extension to be used.
/// 
/// Valid Options: HTTP, NETWORK
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecWasmTypeEnum>))]
public enum V1alpha1TrafficExtensionSpecWasmTypeEnum
{
    [EnumMember(Value = "UNSPECIFIED_PLUGIN_TYPE"), JsonStringEnumMemberName("UNSPECIFIED_PLUGIN_TYPE")]
    UNSPECIFIEDPLUGINTYPE,
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "NETWORK"), JsonStringEnumMemberName("NETWORK")]
    NETWORK
}

/// <summary>
/// Source for the environment variable&apos;s value.
/// 
/// Valid Options: INLINE, HOST
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TrafficExtensionSpecWasmVmConfigEnvValueFromEnum>))]
public enum V1alpha1TrafficExtensionSpecWasmVmConfigEnvValueFromEnum
{
    [EnumMember(Value = "INLINE"), JsonStringEnumMemberName("INLINE")]
    INLINE,
    [EnumMember(Value = "HOST"), JsonStringEnumMemberName("HOST")]
    HOST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecWasmVmConfigEnv
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value for the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Source for the environment variable&apos;s value.
    /// 
    /// Valid Options: INLINE, HOST
    /// </summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TrafficExtensionSpecWasmVmConfigEnvValueFromEnum? ValueFrom { get; set; }
}

/// <summary>Configuration for a Wasm VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecWasmVmConfig
{
    /// <summary>Specifies environment variables to be injected to this VM.</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1TrafficExtensionSpecWasmVmConfigEnv>? Env { get; set; }
}

/// <summary>WebAssembly filter configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpecWasm
{
    /// <summary>
    /// Specifies the failure behavior for the plugin due to fatal errors.
    /// 
    /// Valid Options: FAIL_CLOSE, FAIL_OPEN, FAIL_RELOAD
    /// </summary>
    [JsonPropertyName("failStrategy")]
    public V1alpha1TrafficExtensionSpecWasmFailStrategyEnum? FailStrategy { get; set; }

    /// <summary>
    /// The pull behaviour to be applied when fetching Wasm module by either OCI image or `http/https`.
    /// 
    /// Valid Options: IfNotPresent, Always
    /// </summary>
    [JsonPropertyName("imagePullPolicy")]
    public V1alpha1TrafficExtensionSpecWasmImagePullPolicyEnum? ImagePullPolicy { get; set; }

    /// <summary>Credentials to use for OCI image pulling.</summary>
    [JsonPropertyName("imagePullSecret")]
    public string? ImagePullSecret { get; set; }

    /// <summary>The configuration that will be passed on to the plugin.</summary>
    [JsonPropertyName("pluginConfig")]
    public JsonNode? PluginConfig { get; set; }

    /// <summary>The plugin name to be used in the Envoy configuration (used to be called `rootID`).</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>SHA256 checksum that will be used to verify Wasm module or OCI container.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }

    /// <summary>
    /// Specifies the type of Wasm Extension to be used.
    /// 
    /// Valid Options: HTTP, NETWORK
    /// </summary>
    [JsonPropertyName("type")]
    public V1alpha1TrafficExtensionSpecWasmTypeEnum? Type { get; set; }

    /// <summary>URL of a Wasm module or OCI container.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("verificationKey")]
    public string? VerificationKey { get; set; }

    /// <summary>Configuration for a Wasm VM.</summary>
    [JsonPropertyName("vmConfig")]
    public V1alpha1TrafficExtensionSpecWasmVmConfig? VmConfig { get; set; }
}

/// <summary>Extend the functionality provided by the Istio proxy through WebAssembly or Lua filters. See more details at: https://istio.io/docs/reference/config/proxy_extensions/traffic_extension.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrafficExtensionSpec
{
    /// <summary>Lua filter configuration.</summary>
    [JsonPropertyName("lua")]
    public V1alpha1TrafficExtensionSpecLua? Lua { get; set; }

    /// <summary>Specifies the criteria to determine which traffic is passed to TrafficExtension.</summary>
    [JsonPropertyName("match")]
    public IList<V1alpha1TrafficExtensionSpecMatch>? Match { get; set; }

    /// <summary>
    /// Determines where in the filter chain this `TrafficExtension` is to be injected.
    /// 
    /// Valid Options: AUTHN, AUTHZ, STATS
    /// </summary>
    [JsonPropertyName("phase")]
    public V1alpha1TrafficExtensionSpecPhaseEnum? Phase { get; set; }

    /// <summary>Determines ordering of `TrafficExtensions` in the same `phase`.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1TrafficExtensionSpecSelector? Selector { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1TrafficExtensionSpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>WebAssembly filter configuration.</summary>
    [JsonPropertyName("wasm")]
    public V1alpha1TrafficExtensionSpecWasm? Wasm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TrafficExtension : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TrafficExtensionSpec>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TrafficExtension";
    public const string KubeGroup = "extensions.istio.io";
    public const string KubePluralName = "trafficextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "extensions.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficExtension";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Extend the functionality provided by the Istio proxy through WebAssembly or Lua filters. See more details at: https://istio.io/docs/reference/config/proxy_extensions/traffic_extension.html</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1TrafficExtensionSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}