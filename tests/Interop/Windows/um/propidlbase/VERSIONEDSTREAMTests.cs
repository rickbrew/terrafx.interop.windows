// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VERSIONEDSTREAM" /> struct.</summary>
    public static unsafe partial class VERSIONEDSTREAMTests
    {
        /// <summary>Validates that the <see cref="VERSIONEDSTREAM" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VERSIONEDSTREAM>(), Is.EqualTo(sizeof(VERSIONEDSTREAM)));
        }

        /// <summary>Validates that the <see cref="VERSIONEDSTREAM" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VERSIONEDSTREAM).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VERSIONEDSTREAM" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VERSIONEDSTREAM), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VERSIONEDSTREAM), Is.EqualTo(20));
            }
        }
    }
}
