namespace Expecto.FluentAssertions
open Expecto
module StringExtensions =
    type System.String with
        member this.ShouldBeNotEmpty(message) =
            Expect.isNotEmpty this message
        member this.ShouldBeNotWhitespace message =
            Expect.isNotWhitespace this message
            
        member this.ShouldContains (substring: string) message =
            Expect.stringContains this substring message

        member this.ShouldStartsWith (prefix: string) message =
            Expect.stringStarts this prefix message

        member this.ShouldEndsWith (postfix: string) message =
            Expect.stringEnds this postfix message

        member this.ShouldHasLengthOf (length: int) message =
            Expect.stringHasLength this length message
        
        member this.ShouldMatch pattern message =
            Expect.isMatch this pattern message

        member this.ShouldNotMatch pattern message =
            Expect.isNotMatch this pattern message

        member this.ShouldMatchRegex regex message =
            Expect.isRegexMatch this regex message

        member this.ShouldNotRegexMatch regex message =
            Expect.isMatch this regex message

        member this.ShouldBeEqual equalTo message =
            Expect.equal this equalTo message

        member this.ShouldBeNotEqual equalTo message =
            Expect.notEqual this equalTo message
        

