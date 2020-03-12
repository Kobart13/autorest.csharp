// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace body_array.Models
{
    internal static class FooEnumExtensions
    {
        public static string ToSerialString(this FooEnum value) => value switch
        {
            FooEnum.Foo1 => "foo1",
            FooEnum.Foo2 => "foo2",
            FooEnum.Foo3 => "foo3",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FooEnum value.")
        };

        public static FooEnum ToFooEnum(this string value)
        {
            if (string.Equals(value, "foo1", StringComparison.InvariantCultureIgnoreCase)) return FooEnum.Foo1;
            if (string.Equals(value, "foo2", StringComparison.InvariantCultureIgnoreCase)) return FooEnum.Foo2;
            if (string.Equals(value, "foo3", StringComparison.InvariantCultureIgnoreCase)) return FooEnum.Foo3;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FooEnum value.");
        }
    }
}
