// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "DXGIDeclareAdapterRemovalSupport", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIDeclareAdapterRemovalSupport();
    }
}