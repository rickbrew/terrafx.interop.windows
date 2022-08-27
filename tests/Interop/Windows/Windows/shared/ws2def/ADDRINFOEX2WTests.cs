// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ADDRINFOEX2W" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class ADDRINFOEX2WTests
{
    /// <summary>Validates that the <see cref="ADDRINFOEX2W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFOEX2W>(), Is.EqualTo(sizeof(ADDRINFOEX2W)));
    }

    /// <summary>Validates that the <see cref="ADDRINFOEX2W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFOEX2W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ADDRINFOEX2W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFOEX2W), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(ADDRINFOEX2W), Is.EqualTo(52));
        }
    }
}
