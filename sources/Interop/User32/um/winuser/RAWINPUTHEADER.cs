// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct RAWINPUTHEADER
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("HANDLE")]
        public IntPtr hDevice;

        [NativeTypeName("WPARAM")]
        public UIntPtr wParam;
    }
}