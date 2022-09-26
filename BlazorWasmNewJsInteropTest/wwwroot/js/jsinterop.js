// Here is some JS code that can be imported
// and called from anywhere in the Blazor WASM app.

export function GetHRef() {
    return globalThis.window.location.href;
}
