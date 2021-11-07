// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIB_UDPSTATS2" /> struct.</summary>
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static unsafe partial class MIB_UDPSTATS2Tests
    {
        /// <summary>Validates that the <see cref="MIB_UDPSTATS2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIB_UDPSTATS2>(), Is.EqualTo(sizeof(MIB_UDPSTATS2)));
        }

        /// <summary>Validates that the <see cref="MIB_UDPSTATS2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIB_UDPSTATS2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIB_UDPSTATS2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIB_UDPSTATS2), Is.EqualTo(32));
        }
    }
}
