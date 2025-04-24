namespace Project_alpha

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Templating
open WebSharper.UI.Html

[<JavaScript>]
module Client =
    // The templates are loaded from the DOM, so you just can edit index.html
    // and refresh your browser, no need to recompile unless you add or remove holes.
    type IndexTemplate = Template<"wwwroot/index.html", ClientLoad.FromDocument>


    [<SPAEntryPoint>]
    let Main () : Doc =
        div [attr.``class`` "app-container"] [

        h1 [attr.``class`` "app-title"] [text "🎯 Fókusz Időzítő"]

        div [attr.``class`` "timer-display"] [
            text "25:00"
        ]

        div [attr.``class`` "controls"] [
            button [attr.``class`` "btn start-btn"] [text "▶️ Start"]
            button [attr.``class`` "btn stop-btn"] [text "⏹ Stop"]
            button [attr.``class`` "btn reset-btn"] [text "🔄 Reset"]
        ]

        div [attr.``class`` "mode-selector"] [
            button [attr.``class`` "btn mode-btn"] [text "☕ Rövid szünet"]
            button [attr.``class`` "btn mode-btn"] [text "🛌 Hosszú szünet"]
        ]

        div [attr.``class`` "status-indicator"] [
            text "Aktív szakasz"
        ]

        footer [] [
            p [] [text "Készült WebSharper SPA-val ❤️"]
        ]
    ]
