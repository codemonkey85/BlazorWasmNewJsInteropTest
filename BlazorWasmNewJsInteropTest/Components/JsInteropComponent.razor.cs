namespace BlazorWasmNewJsInteropTest.Components;

public partial class JsInteropComponent
{
    private string href = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (OperatingSystem.IsBrowser())
        {
            await JSHost.ImportAsync("../js/jsinterop.js", "../js/jsinterop.js");
            await JSHost.ImportAsync("JsInteropComponent.razor.js", "../Components/JsInteropComponent.razor.js");
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
