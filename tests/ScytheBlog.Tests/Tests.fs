module ScytheBlog.Tests

open ScytheBlog
open Xunit
open Swensen.Unquote

[<Fact>]
let ``hello returns 42`` () =
  test <@ (pown 2 5) + (pown 2 3) + (pown 2 1) = 42 @>
