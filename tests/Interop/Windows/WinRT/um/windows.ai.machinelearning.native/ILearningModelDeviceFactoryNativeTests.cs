// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests
{
    /// <summary>Provides validation of the <see cref="ILearningModelDeviceFactoryNative" /> struct.</summary>
    public static unsafe partial class ILearningModelDeviceFactoryNativeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ILearningModelDeviceFactoryNative" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ILearningModelDeviceFactoryNative).GUID, Is.EqualTo(IID_ILearningModelDeviceFactoryNative));
        }

        /// <summary>Validates that the <see cref="ILearningModelDeviceFactoryNative" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ILearningModelDeviceFactoryNative>(), Is.EqualTo(sizeof(ILearningModelDeviceFactoryNative)));
        }

        /// <summary>Validates that the <see cref="ILearningModelDeviceFactoryNative" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ILearningModelDeviceFactoryNative).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ILearningModelDeviceFactoryNative" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ILearningModelDeviceFactoryNative), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ILearningModelDeviceFactoryNative), Is.EqualTo(4));
            }
        }
    }
}
