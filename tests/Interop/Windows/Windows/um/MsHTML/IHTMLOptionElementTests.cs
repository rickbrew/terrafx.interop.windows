// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLOptionElement" /> struct.</summary>
    public static unsafe partial class IHTMLOptionElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLOptionElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLOptionElement).GUID, Is.EqualTo(IID_IHTMLOptionElement));
        }

        /// <summary>Validates that the <see cref="IHTMLOptionElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLOptionElement>(), Is.EqualTo(sizeof(IHTMLOptionElement)));
        }

        /// <summary>Validates that the <see cref="IHTMLOptionElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLOptionElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLOptionElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLOptionElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLOptionElement), Is.EqualTo(4));
            }
        }
    }
}
