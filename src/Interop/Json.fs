module Thoth.Json.Python.Interop.Json

open Fable.Core

[<Erase>]
type IExports =
    abstract dumps: obj: obj -> string
    abstract loads: string -> obj

[<ImportAll("json")>]
let json: IExports = nativeOnly

[<Erase>]
type IExports2 =
    [<NamedParams(fromIndex = 1)>]
    abstract dumps:
        obj: obj *
        ?indent: (int Option) *
        ?separators: (string * string) ->
            string
    abstract loads: string -> obj

[<ImportAll("json")>]
let json2: IExports2 = nativeOnly
