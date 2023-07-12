module Thoth.Json.Python.Interop.Json

open Fable.Core

[<Erase>]
type IExports =
    [<NamedParams(fromIndex = 1)>]
    abstract dumps:
        obj: obj *
        ?indent: (int Option) *
        ?separators: (string * string) ->
            string
    abstract loads: string -> obj

[<ImportAll("json")>]
let json: IExports = nativeOnly
