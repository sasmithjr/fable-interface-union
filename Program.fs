// For more information see https://aka.ms/fsharp-console-apps

type ErrorUnion<'Error when 'Error :> Interface.IErrorInterface> =
    | Error of 'Error

printfn "Hello from F#"
