module StringsTests

open FsUnit.Xunit
open Xunit

open Strings

[<Fact>]
let ``Error message``() = message "[ERROR]: Stack overflow" |> should equal "Stack overflow"
