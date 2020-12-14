// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MLOperatorSchemaDescription" /> struct.</summary>
    public static unsafe class MLOperatorSchemaDescriptionTests
    {
        /// <summary>Validates that the <see cref="MLOperatorSchemaDescription" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MLOperatorSchemaDescription>(), Is.EqualTo(sizeof(MLOperatorSchemaDescription)));
        }

        /// <summary>Validates that the <see cref="MLOperatorSchemaDescription" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MLOperatorSchemaDescription).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MLOperatorSchemaDescription" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MLOperatorSchemaDescription), Is.EqualTo(96));
            }
            else
            {
                Assert.That(sizeof(MLOperatorSchemaDescription), Is.EqualTo(48));
            }
        }
    }
}
