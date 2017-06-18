namespace Expecto.FluentAssertions
open Expecto
module BoolExtensions =
    type System.Boolean with
        member this.ShouldBeTrue message =
            Expect.isTrue this message
        member this.ShouldBeFalse message =
            Expect.isFalse this message