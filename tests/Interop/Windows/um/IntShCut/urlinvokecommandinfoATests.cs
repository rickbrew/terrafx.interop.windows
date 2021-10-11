// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="urlinvokecommandinfoA" /> struct.</summary>
    public static unsafe partial class urlinvokecommandinfoATests
    {
        /// <summary>Validates that the <see cref="urlinvokecommandinfoA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<urlinvokecommandinfoA>(), Is.EqualTo(sizeof(urlinvokecommandinfoA)));
        }

        /// <summary>Validates that the <see cref="urlinvokecommandinfoA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(urlinvokecommandinfoA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="urlinvokecommandinfoA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(urlinvokecommandinfoA), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(urlinvokecommandinfoA), Is.EqualTo(16));
            }
        }
    }
}
