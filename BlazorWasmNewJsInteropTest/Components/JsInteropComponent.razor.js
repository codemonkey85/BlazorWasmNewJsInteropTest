// Here is an example of some razor-scoped JS.

export function ShowAlert(message) {
    globalThis.window.alert(message);
}
