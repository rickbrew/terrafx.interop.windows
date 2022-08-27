// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class JOBOBJECT_CPU_RATE_CONTROL_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<JOBOBJECT_CPU_RATE_CONTROL_INFORMATION>(), Is.EqualTo(sizeof(JOBOBJECT_CPU_RATE_CONTROL_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(JOBOBJECT_CPU_RATE_CONTROL_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(JOBOBJECT_CPU_RATE_CONTROL_INFORMATION), Is.EqualTo(8));
    }
}
