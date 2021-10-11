// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_GUID_AVDecAudioInputPCM" /> struct.</summary>
    public static unsafe partial class CODECAPI_GUID_AVDecAudioInputPCMTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_GUID_AVDecAudioInputPCM" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_GUID_AVDecAudioInputPCM).GUID, Is.EqualTo(STATIC_CODECAPI_GUID_AVDecAudioInputPCM));
        }

        /// <summary>Validates that the <see cref="CODECAPI_GUID_AVDecAudioInputPCM" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_GUID_AVDecAudioInputPCM>(), Is.EqualTo(sizeof(CODECAPI_GUID_AVDecAudioInputPCM)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_GUID_AVDecAudioInputPCM" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_GUID_AVDecAudioInputPCM).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_GUID_AVDecAudioInputPCM" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_GUID_AVDecAudioInputPCM), Is.EqualTo(1));
        }
    }
}
