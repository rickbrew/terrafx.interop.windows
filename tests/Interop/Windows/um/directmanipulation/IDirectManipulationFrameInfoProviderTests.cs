// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirectManipulationFrameInfoProvider" /> struct.</summary>
    public static unsafe class IDirectManipulationFrameInfoProviderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirectManipulationFrameInfoProvider" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDirectManipulationFrameInfoProvider).GUID, Is.EqualTo(IID_IDirectManipulationFrameInfoProvider));
        }

        /// <summary>Validates that the <see cref="IDirectManipulationFrameInfoProvider" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDirectManipulationFrameInfoProvider>(), Is.EqualTo(sizeof(IDirectManipulationFrameInfoProvider)));
        }

        /// <summary>Validates that the <see cref="IDirectManipulationFrameInfoProvider" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDirectManipulationFrameInfoProvider).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDirectManipulationFrameInfoProvider" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDirectManipulationFrameInfoProvider), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDirectManipulationFrameInfoProvider), Is.EqualTo(4));
            }
        }
    }
}
