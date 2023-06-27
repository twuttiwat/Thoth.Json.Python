module Tests.Main

open Fable.Core

let describe (name: string) (f: unit->unit) =
    printfn "Describe: %s" name
    f ()

let it (msg: string) (f: unit->unit) =
    printfn "Msg: %s" msg
    f ()

let run () =
    let tests = [ Tests.Decoders.tests
                  Tests.Encoders.tests
                  Tests.ExtraCoders.tests
                  Tests.BackAndForth.tests
                ] :> Util.Testing.Test seq

    for (moduleName, moduleTests) in tests do
        describe moduleName <| fun () ->
            for (name, tests) in moduleTests do
                describe name <| fun _ ->
                    for (msg, test) in tests do
                        it msg test

run()
