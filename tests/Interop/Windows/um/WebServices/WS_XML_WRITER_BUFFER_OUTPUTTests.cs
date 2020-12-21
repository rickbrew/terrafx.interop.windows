// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WS_XML_WRITER_BUFFER_OUTPUT" /> struct.</summary>
    public static unsafe class WS_XML_WRITER_BUFFER_OUTPUTTests
    {
        /// <summary>Validates that the <see cref="WS_XML_WRITER_BUFFER_OUTPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WS_XML_WRITER_BUFFER_OUTPUT>(), Is.EqualTo(sizeof(WS_XML_WRITER_BUFFER_OUTPUT)));
        }

        /// <summary>Validates that the <see cref="WS_XML_WRITER_BUFFER_OUTPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WS_XML_WRITER_BUFFER_OUTPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WS_XML_WRITER_BUFFER_OUTPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WS_XML_WRITER_BUFFER_OUTPUT), Is.EqualTo(4));
        }
    }
}
