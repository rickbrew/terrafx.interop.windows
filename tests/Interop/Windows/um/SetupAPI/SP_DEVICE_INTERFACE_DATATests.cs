// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_DEVICE_INTERFACE_DATA" /> struct.</summary>
    public static unsafe partial class SP_DEVICE_INTERFACE_DATATests
    {
        /// <summary>Validates that the <see cref="SP_DEVICE_INTERFACE_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_DEVICE_INTERFACE_DATA>(), Is.EqualTo(sizeof(SP_DEVICE_INTERFACE_DATA)));
        }

        /// <summary>Validates that the <see cref="SP_DEVICE_INTERFACE_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_DEVICE_INTERFACE_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_DEVICE_INTERFACE_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SP_DEVICE_INTERFACE_DATA), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(SP_DEVICE_INTERFACE_DATA), Is.EqualTo(28));
            }
        }
    }
}
