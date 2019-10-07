// SYNTAX TEST "source.cs" "attributes"

        [Foo]
//      ^       punctuation.squarebracket.open.cs
//       ^^^    storage.type.cs
//          ^   punctuation.squarebracket.close.cs

        [assembly: Foo]
//      ^                 punctuation.squarebracket.open.cs
//               ^        punctuation.separator.colon.cs
//                    ^   punctuation.squarebracket.close.cs
//       ^^^^^^^^         keyword.other.attribute-specifier.cs
//                 ^^^    storage.type.cs

        [module: Foo, Bar]
        