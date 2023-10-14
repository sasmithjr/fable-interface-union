// type UnionWithoutError =
//     | NoError of Source.IErrorInterface

// type ClassWithoutError1<'Error when 'Error :> Source.IErrorInterface>(e: 'Error) =
//     member _.Error = e

// type ClassWithoutErro2(e: Source.IErrorInterface) =
//     member _.Error = e

// type RecordWithoutError1<'Error when 'Error :> Source.IErrorInterface> =
//     { Error : 'Error }

// type RecordWithoutError2 =
    // { Error : Source.IErrorInterface }

type ErrorUnion<'Error when 'Error :> Source.IErrorInterface> =
    | Error of 'Error

printfn "Hello from F#"
