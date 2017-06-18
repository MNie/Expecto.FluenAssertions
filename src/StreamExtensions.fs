namespace Expecto.FluentAssertions
open Expecto
module StreamsExtensions =
    type System.IO.Stream with
        member this.ShouldEqual (second: System.IO.Stream) message =
            Expect.streamsEqual this second message