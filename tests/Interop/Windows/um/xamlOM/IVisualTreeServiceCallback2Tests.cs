// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IVisualTreeServiceCallback2" /> struct.</summary>
    public static unsafe partial class IVisualTreeServiceCallback2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IVisualTreeServiceCallback2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IVisualTreeServiceCallback2).GUID, Is.EqualTo(IID_IVisualTreeServiceCallback2));
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IVisualTreeServiceCallback2>(), Is.EqualTo(sizeof(IVisualTreeServiceCallback2)));
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IVisualTreeServiceCallback2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IVisualTreeServiceCallback2), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IVisualTreeServiceCallback2), Is.EqualTo(4));
            }
        }
    }
}
