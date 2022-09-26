namespace BlazorWasmNewJsInteropTest;

[SupportedOSPlatform("browser")]
public partial class JsInterop
{
    [JSImport("GetHRef", "../js/jsinterop.js")]
    public static partial string GetHRef();

    [JSImport("ShowAlert", "JsInteropComponent.razor.js")]
    public static partial void ShowAlert(string message);
}
