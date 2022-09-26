namespace BlazorWasmNewJsInteropTest.Components;

public partial class JsInteropComponent
{
    private string href = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (OperatingSystem.IsBrowser())
        {
            // Call from JS in wwwroot
            await JSHost.ImportAsync("jsinterop.js", "../js/jsinterop.js");

            // Call from razor-scoped JS
            await JSHost.ImportAsync(
                $"{nameof(JsInteropComponent)}.razor.js",
                $"../{nameof(Components)}/{nameof(JsInteropComponent)}.razor.js");
        }
    }

    private void GetHRef()
    {
        href = JsInterop.GetHRef();
    }

    private void ShowAlert(string message)
    {
        JsInterop.ShowAlert(message);
    }
}
