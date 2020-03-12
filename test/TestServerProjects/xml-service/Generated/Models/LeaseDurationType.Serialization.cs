// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    internal static class LeaseDurationTypeExtensions
    {
        public static string ToSerialString(this LeaseDurationType value) => value switch
        {
            LeaseDurationType.Infinite => "infinite",
            LeaseDurationType.Fixed => "fixed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseDurationType value.")
        };

        public static LeaseDurationType ToLeaseDurationType(this string value)
        {
            if (string.Equals(value, "infinite", StringComparison.InvariantCultureIgnoreCase)) return LeaseDurationType.Infinite;
            if (string.Equals(value, "fixed", StringComparison.InvariantCultureIgnoreCase)) return LeaseDurationType.Fixed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseDurationType value.");
        }
    }
}
