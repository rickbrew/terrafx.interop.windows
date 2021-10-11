// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IInitializeWithPropertyStore" /> struct.</summary>
    public static unsafe partial class IInitializeWithPropertyStoreTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IInitializeWithPropertyStore" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IInitializeWithPropertyStore).GUID, Is.EqualTo(IID_IInitializeWithPropertyStore));
        }

        /// <summary>Validates that the <see cref="IInitializeWithPropertyStore" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IInitializeWithPropertyStore>(), Is.EqualTo(sizeof(IInitializeWithPropertyStore)));
        }

        /// <summary>Validates that the <see cref="IInitializeWithPropertyStore" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IInitializeWithPropertyStore).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IInitializeWithPropertyStore" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IInitializeWithPropertyStore), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IInitializeWithPropertyStore), Is.EqualTo(4));
            }
        }
    }
}
