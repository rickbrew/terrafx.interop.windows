// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICComponentInfo" /> struct.</summary>
    public static unsafe partial class IWICComponentInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICComponentInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICComponentInfo).GUID, Is.EqualTo(IID_IWICComponentInfo));
        }

        /// <summary>Validates that the <see cref="IWICComponentInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IWICComponentInfo>(), Is.EqualTo(sizeof(IWICComponentInfo)));
        }

        /// <summary>Validates that the <see cref="IWICComponentInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICComponentInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IWICComponentInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IWICComponentInfo), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IWICComponentInfo), Is.EqualTo(4));
            }
        }
    }
}
