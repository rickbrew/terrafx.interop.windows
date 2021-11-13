// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWebBrowserEvents" /> struct.</summary>
    public static unsafe partial class DWebBrowserEventsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DWebBrowserEvents" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DWebBrowserEvents).GUID, Is.EqualTo(IID_DWebBrowserEvents));
        }

        /// <summary>Validates that the <see cref="DWebBrowserEvents" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DWebBrowserEvents>(), Is.EqualTo(sizeof(DWebBrowserEvents)));
        }

        /// <summary>Validates that the <see cref="DWebBrowserEvents" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWebBrowserEvents).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DWebBrowserEvents" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DWebBrowserEvents), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(DWebBrowserEvents), Is.EqualTo(4));
            }
        }
    }
}
