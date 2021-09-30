// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_RASTERIZER_DESC1
    {
        public static ref readonly D3D11_RASTERIZER_DESC1 DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x00, 0x00, 0x00,
                    0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D3D11_RASTERIZER_DESC1>());
                return ref Unsafe.As<byte, D3D11_RASTERIZER_DESC1>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D3D11_RASTERIZER_DESC1(D3D11_FILL_MODE fillMode, D3D11_CULL_MODE cullMode, [NativeTypeName("BOOL")] int frontCounterClockwise, [NativeTypeName("INT")] int depthBias, [NativeTypeName("FLOAT")] float depthBiasClamp, [NativeTypeName("FLOAT")] float slopeScaledDepthBias, [NativeTypeName("BOOL")] int depthClipEnable, [NativeTypeName("BOOL")] int scissorEnable, [NativeTypeName("BOOL")] int multisampleEnable, [NativeTypeName("BOOL")] int antialiasedLineEnable, [NativeTypeName("UINT")] uint forcedSampleCount)
        {
            FillMode = fillMode;
            CullMode = cullMode;
            FrontCounterClockwise = frontCounterClockwise;
            DepthBias = depthBias;
            DepthBiasClamp = depthBiasClamp;
            SlopeScaledDepthBias = slopeScaledDepthBias;
            DepthClipEnable = depthClipEnable;
            ScissorEnable = scissorEnable;
            MultisampleEnable = multisampleEnable;
            AntialiasedLineEnable = antialiasedLineEnable;
            ForcedSampleCount = forcedSampleCount;
        }
    }
}
