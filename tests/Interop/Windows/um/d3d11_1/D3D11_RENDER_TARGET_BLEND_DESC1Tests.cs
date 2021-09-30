// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D11_BLEND;
using static TerraFX.Interop.D3D11_BLEND_OP;
using static TerraFX.Interop.D3D11_COLOR_WRITE_ENABLE;
using static TerraFX.Interop.D3D11_LOGIC_OP;
using static TerraFX.Interop.D3D11_RENDER_TARGET_BLEND_DESC1;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_RENDER_TARGET_BLEND_DESC1" /> struct.</summary>
    public static unsafe class D3D11_RENDER_TARGET_BLEND_DESC1Tests
    {
        /// <summary>Validates that the <see cref="D3D11_RENDER_TARGET_BLEND_DESC1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_RENDER_TARGET_BLEND_DESC1>(), Is.EqualTo(sizeof(D3D11_RENDER_TARGET_BLEND_DESC1)));
        }

        /// <summary>Validates that the <see cref="D3D11_RENDER_TARGET_BLEND_DESC1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_RENDER_TARGET_BLEND_DESC1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_RENDER_TARGET_BLEND_DESC1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_RENDER_TARGET_BLEND_DESC1), Is.EqualTo(40));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.BlendEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.LogicOpEnable, Is.EqualTo(FALSE));
            Assert.That(DEFAULT.SrcBlend, Is.EqualTo(D3D11_BLEND_ONE));
            Assert.That(DEFAULT.DestBlend, Is.EqualTo(D3D11_BLEND_ZERO));
            Assert.That(DEFAULT.BlendOp, Is.EqualTo(D3D11_BLEND_OP_ADD));
            Assert.That(DEFAULT.SrcBlendAlpha, Is.EqualTo(D3D11_BLEND_ONE));
            Assert.That(DEFAULT.DestBlendAlpha, Is.EqualTo(D3D11_BLEND_ZERO));
            Assert.That(DEFAULT.BlendOpAlpha, Is.EqualTo(D3D11_BLEND_OP_ADD));
            Assert.That(DEFAULT.LogicOp, Is.EqualTo(D3D11_LOGIC_OP_NOOP));
            Assert.That(DEFAULT.RenderTargetWriteMask, Is.EqualTo((byte)D3D11_COLOR_WRITE_ENABLE_ALL));
        }
    }
}
