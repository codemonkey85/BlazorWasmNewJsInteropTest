namespace BlazorWasmNewJsInteropTest;

[SupportedOSPlatform("browser")]
public partial class JsInterop
{

    [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(JsonTypeInfo))]
    [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(JsonSerializerContext))]
    static JsInterop() { }

    [JSImport("GetHRef", "../js/jsinterop.js")]
    public static partial string GetHRef();

    [JSImport("ShowAlert", "JsInteropComponent.razor.js")]
    public static partial void ShowAlert(string message);
}
