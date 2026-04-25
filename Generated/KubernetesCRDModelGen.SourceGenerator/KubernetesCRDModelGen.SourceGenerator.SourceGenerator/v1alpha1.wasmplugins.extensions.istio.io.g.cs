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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WasmPluginList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WasmPlugin>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WasmPluginList";
    public const string KubeGroup = "extensions.istio.io";
    public const string KubePluralName = "wasmplugins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "extensions.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WasmPluginList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WasmPlugin objects.</summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1WasmPlugin>? Items { get; set; }
}

/// <summary>
/// Specifies the failure behavior for the plugin due to fatal errors.
/// 
/// Valid Options: FAIL_CLOSE, FAIL_OPEN, FAIL_RELOAD
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecFailStrategyEnum>))]
public enum V1alpha1WasmPluginSpecFailStrategyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecImagePullPolicyEnum>))]
public enum V1alpha1WasmPluginSpecImagePullPolicyEnum
{
    [EnumMember(Value = "UNSPECIFIED_POLICY"), JsonStringEnumMemberName("UNSPECIFIED_POLICY")]
    UNSPECIFIEDPOLICY,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always
}

/// <summary>
/// Criteria for selecting traffic by their direction.
/// 
/// Valid Options: CLIENT, SERVER, CLIENT_AND_SERVER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecMatchModeEnum>))]
public enum V1alpha1WasmPluginSpecMatchModeEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecMatchPorts
{
    [JsonPropertyName("number")]
    public required int Number { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecMatch
{
    /// <summary>
    /// Criteria for selecting traffic by their direction.
    /// 
    /// Valid Options: CLIENT, SERVER, CLIENT_AND_SERVER
    /// </summary>
    [JsonPropertyName("mode")]
    public V1alpha1WasmPluginSpecMatchModeEnum? Mode { get; set; }

    /// <summary>Criteria for selecting traffic by their destination port.</summary>
    [JsonPropertyName("ports")]
    public IList<V1alpha1WasmPluginSpecMatchPorts>? Ports { get; set; }
}

/// <summary>
/// Determines where in the filter chain this `WasmPlugin` is to be injected.
/// 
/// Valid Options: AUTHN, AUTHZ, STATS
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecPhaseEnum>))]
public enum V1alpha1WasmPluginSpecPhaseEnum
{
    [EnumMember(Value = "UNSPECIFIED_PHASE"), JsonStringEnumMemberName("UNSPECIFIED_PHASE")]
    UNSPECIFIEDPHASE,
    [EnumMember(Value = "AUTHN"), JsonStringEnumMemberName("AUTHN")]
    AUTHN,
    [EnumMember(Value = "AUTHZ"), JsonStringEnumMemberName("AUTHZ")]
    AUTHZ,
    [EnumMember(Value = "STATS"), JsonStringEnumMemberName("STATS")]
    STATS
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this plugin configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which a policy should be applied.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecTargetRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecTargetRefs
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
/// Specifies the type of Wasm Extension to be used.
/// 
/// Valid Options: HTTP, NETWORK
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecTypeEnum>))]
public enum V1alpha1WasmPluginSpecTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum>))]
public enum V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum
{
    [EnumMember(Value = "INLINE"), JsonStringEnumMemberName("INLINE")]
    INLINE,
    [EnumMember(Value = "HOST"), JsonStringEnumMemberName("HOST")]
    HOST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecVmConfigEnv
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
    public V1alpha1WasmPluginSpecVmConfigEnvValueFromEnum? ValueFrom { get; set; }
}

/// <summary>Configuration for a Wasm VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpecVmConfig
{
    /// <summary>Specifies environment variables to be injected to this VM.</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1WasmPluginSpecVmConfigEnv>? Env { get; set; }
}

/// <summary>Extend the functionality provided by the Istio proxy through WebAssembly filters. See more details at: https://istio.io/docs/reference/config/proxy_extensions/wasm-plugin.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WasmPluginSpec
{
    /// <summary>
    /// Specifies the failure behavior for the plugin due to fatal errors.
    /// 
    /// Valid Options: FAIL_CLOSE, FAIL_OPEN, FAIL_RELOAD
    /// </summary>
    [JsonPropertyName("failStrategy")]
    public V1alpha1WasmPluginSpecFailStrategyEnum? FailStrategy { get; set; }

    /// <summary>
    /// The pull behaviour to be applied when fetching Wasm module by either OCI image or `http/https`.
    /// 
    /// Valid Options: IfNotPresent, Always
    /// </summary>
    [JsonPropertyName("imagePullPolicy")]
    public V1alpha1WasmPluginSpecImagePullPolicyEnum? ImagePullPolicy { get; set; }

    /// <summary>Credentials to use for OCI image pulling.</summary>
    [JsonPropertyName("imagePullSecret")]
    public string? ImagePullSecret { get; set; }

    /// <summary>Specifies the criteria to determine which traffic is passed to WasmPlugin.</summary>
    [JsonPropertyName("match")]
    public IList<V1alpha1WasmPluginSpecMatch>? Match { get; set; }

    /// <summary>
    /// Determines where in the filter chain this `WasmPlugin` is to be injected.
    /// 
    /// Valid Options: AUTHN, AUTHZ, STATS
    /// </summary>
    [JsonPropertyName("phase")]
    public V1alpha1WasmPluginSpecPhaseEnum? Phase { get; set; }

    /// <summary>The configuration that will be passed on to the plugin.</summary>
    [JsonPropertyName("pluginConfig")]
    public JsonNode? PluginConfig { get; set; }

    /// <summary>The plugin name to be used in the Envoy configuration (used to be called `rootID`).</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>Determines ordering of `WasmPlugins` in the same `phase`.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this plugin configuration should be applied.</summary>
    [JsonPropertyName("selector")]
    public V1alpha1WasmPluginSpecSelector? Selector { get; set; }

    /// <summary>SHA256 checksum that will be used to verify Wasm module or OCI container.</summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }

    [JsonPropertyName("targetRef")]
    public V1alpha1WasmPluginSpecTargetRef? TargetRef { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha1WasmPluginSpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>
    /// Specifies the type of Wasm Extension to be used.
    /// 
    /// Valid Options: HTTP, NETWORK
    /// </summary>
    [JsonPropertyName("type")]
    public V1alpha1WasmPluginSpecTypeEnum? Type { get; set; }

    /// <summary>URL of a Wasm module or OCI container.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("verificationKey")]
    public string? VerificationKey { get; set; }

    /// <summary>Configuration for a Wasm VM.</summary>
    [JsonPropertyName("vmConfig")]
    public V1alpha1WasmPluginSpecVmConfig? VmConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.5.2+8c7b4a3647c1e77cd3e3152af5701ec2357dafe9")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WasmPlugin : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WasmPluginSpec>, IStatus<JsonNode?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WasmPlugin";
    public const string KubeGroup = "extensions.istio.io";
    public const string KubePluralName = "wasmplugins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "extensions.istio.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WasmPlugin";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Extend the functionality provided by the Istio proxy through WebAssembly filters. See more details at: https://istio.io/docs/reference/config/proxy_extensions/wasm-plugin.html</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1WasmPluginSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}