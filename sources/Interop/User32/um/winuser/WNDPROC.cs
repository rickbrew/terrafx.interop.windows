// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("LRESULT")]
    public unsafe delegate IntPtr WNDPROC([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("WPARAM")] UIntPtr param2, [NativeTypeName("LPARAM")] IntPtr param3);
}
