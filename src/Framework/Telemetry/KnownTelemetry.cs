﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Build.Framework.Telemetry;

/// <summary>
/// Static class to help access and modify known telemetries.
/// </summary>
internal static class KnownTelemetry
{
    /// <summary>
    /// Partial Telemetry for build.
    /// This could be optionally initialized with some values from early in call stack, for example in Main method.
    /// After this instance is acquired by a particular build, this is set to null.
    /// Null means there are no prior collected build telemetry data, new clean instance shall be created for particular build.
    /// </summary>
    public static BuildTelemetry? PartialBuildTelemetry { get; set; }
}
