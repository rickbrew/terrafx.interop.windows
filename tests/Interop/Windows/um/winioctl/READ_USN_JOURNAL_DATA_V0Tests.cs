// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="READ_USN_JOURNAL_DATA_V0" /> struct.</summary>
    public static unsafe partial class READ_USN_JOURNAL_DATA_V0Tests
    {
        /// <summary>Validates that the <see cref="READ_USN_JOURNAL_DATA_V0" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<READ_USN_JOURNAL_DATA_V0>(), Is.EqualTo(sizeof(READ_USN_JOURNAL_DATA_V0)));
        }

        /// <summary>Validates that the <see cref="READ_USN_JOURNAL_DATA_V0" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(READ_USN_JOURNAL_DATA_V0).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="READ_USN_JOURNAL_DATA_V0" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(READ_USN_JOURNAL_DATA_V0), Is.EqualTo(40));
        }
    }
}
