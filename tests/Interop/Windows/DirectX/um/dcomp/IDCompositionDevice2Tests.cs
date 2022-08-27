// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDCompositionDevice2" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDCompositionDevice2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionDevice2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionDevice2).GUID, Is.EqualTo(IID_IDCompositionDevice2));
    }

    /// <summary>Validates that the <see cref="IDCompositionDevice2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionDevice2>(), Is.EqualTo(sizeof(IDCompositionDevice2)));
    }

    /// <summary>Validates that the <see cref="IDCompositionDevice2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionDevice2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDCompositionDevice2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionDevice2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionDevice2), Is.EqualTo(4));
        }
    }
}
