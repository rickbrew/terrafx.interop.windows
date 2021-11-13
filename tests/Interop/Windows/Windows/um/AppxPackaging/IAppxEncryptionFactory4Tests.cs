// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxEncryptionFactory4" /> struct.</summary>
    [SupportedOSPlatform("windows10.0")]
    public static unsafe partial class IAppxEncryptionFactory4Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxEncryptionFactory4" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxEncryptionFactory4).GUID, Is.EqualTo(IID_IAppxEncryptionFactory4));
        }

        /// <summary>Validates that the <see cref="IAppxEncryptionFactory4" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxEncryptionFactory4>(), Is.EqualTo(sizeof(IAppxEncryptionFactory4)));
        }

        /// <summary>Validates that the <see cref="IAppxEncryptionFactory4" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxEncryptionFactory4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxEncryptionFactory4" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxEncryptionFactory4), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxEncryptionFactory4), Is.EqualTo(4));
            }
        }
    }
}
