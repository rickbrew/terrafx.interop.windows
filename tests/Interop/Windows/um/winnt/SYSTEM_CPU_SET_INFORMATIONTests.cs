// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SYSTEM_CPU_SET_INFORMATION" /> struct.</summary>
    public static unsafe partial class SYSTEM_CPU_SET_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="SYSTEM_CPU_SET_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SYSTEM_CPU_SET_INFORMATION>(), Is.EqualTo(sizeof(SYSTEM_CPU_SET_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="SYSTEM_CPU_SET_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SYSTEM_CPU_SET_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SYSTEM_CPU_SET_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SYSTEM_CPU_SET_INFORMATION), Is.EqualTo(32));
        }
    }
}
