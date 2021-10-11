// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="REBARINFO" /> struct.</summary>
    public static unsafe partial class REBARINFOTests
    {
        /// <summary>Validates that the <see cref="REBARINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<REBARINFO>(), Is.EqualTo(sizeof(REBARINFO)));
        }

        /// <summary>Validates that the <see cref="REBARINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(REBARINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="REBARINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(REBARINFO), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(REBARINFO), Is.EqualTo(12));
            }
        }
    }
}
