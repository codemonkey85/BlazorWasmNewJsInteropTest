namespace BlazorWasmNewJsInteropTest;

[SupportedOSPlatform("browser")]
public partial class JsInterop
{
    [JSImport("GetHRef", "jsinterop.js")]
    public static partial string GetHRef();

    [JSImport("ShowAlert", $"{nameof(JsInteropComponent)}.razor.js")]
    public static partial void ShowAlert(string message);
}
