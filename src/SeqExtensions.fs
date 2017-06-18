namespace Expecto.FluentAssertions
open Expecto
module Seq =
    let ShouldHasCountOf sequence (count)(message) =
        Expect.hasCountOf sequence count message
    let ShouldBeEmpty sequence message =
        Expect.isEmpty sequence message
    let ShouldBeNotBeEmpty sequence message =
        Expect.isNonEmpty sequence message

    let ShouldExistsInside sequence asserter message =
        Expect.exists sequence asserter message

    let ShouldAllSatisfies sequence asserter message =
        Expect.all sequence asserter message

    let ShouldAllEqual sequence equalTo message =
        Expect.allEqual sequence equalTo message

    let ShouldContain sequence element message =
        Expect.contains sequence element message

    let ShouldContainsAll sequence (expected: _ seq) message =
        Expect.containsAll sequence expected message

    let ShouldDistribute sequence (expected: Map<_, uint32>) message =
        Expect.distribution sequence expected message
    
    let ShouldBeEqual sequence (expected: _ seq) message =
        Expect.sequenceEqual sequence expected message

    let ShouldStartsWith sequence (prefix: _ seq) message =
        Expect.sequenceStarts sequence prefix message
    
    let ShouldBeAscending sequence message =
        Expect.isAscending sequence message

    let ShouldBeDescending sequence message =
        Expect.isDescending sequence message
    

