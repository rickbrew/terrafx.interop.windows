// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        [NativeTypeName("#define DXDIAG_DX9_SDK_VERSION 111")]
        public const int DXDIAG_DX9_SDK_VERSION = 111;

        [NativeTypeName("#define DXDIAG_E_INSUFFICIENT_BUFFER ((HRESULT)0x8007007AL)")]
        public const int DXDIAG_E_INSUFFICIENT_BUFFER = unchecked((int)(0x8007007A));
    }
}
