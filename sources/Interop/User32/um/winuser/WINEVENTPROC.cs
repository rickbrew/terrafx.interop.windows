// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public unsafe delegate void WINEVENTPROC([NativeTypeName("HWINEVENTHOOK")] IntPtr hWinEventHook, [NativeTypeName("DWORD")] uint @event, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild, [NativeTypeName("DWORD")] uint idEventThread, [NativeTypeName("DWORD")] uint dwmsEventTime);
}
