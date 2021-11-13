// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTMLAreaElement" /> struct.</summary>
    public static unsafe partial class HTMLAreaElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLAreaElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(HTMLAreaElement).GUID, Is.EqualTo(IID_HTMLAreaElement));
        }

        /// <summary>Validates that the <see cref="HTMLAreaElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTMLAreaElement>(), Is.EqualTo(sizeof(HTMLAreaElement)));
        }

        /// <summary>Validates that the <see cref="HTMLAreaElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTMLAreaElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTMLAreaElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HTMLAreaElement), Is.EqualTo(1));
        }
    }
}
