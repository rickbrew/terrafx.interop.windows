// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYNCMGRHANDLERINFO.xml' path='doc/member[@name="SYNCMGRHANDLERINFO"]/*' />
public partial struct SYNCMGRHANDLERINFO
{
    /// <include file='SYNCMGRHANDLERINFO.xml' path='doc/member[@name="SYNCMGRHANDLERINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SYNCMGRHANDLERINFO.xml' path='doc/member[@name="SYNCMGRHANDLERINFO.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='SYNCMGRHANDLERINFO.xml' path='doc/member[@name="SYNCMGRHANDLERINFO.SyncMgrHandlerFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint SyncMgrHandlerFlags;

    /// <include file='SYNCMGRHANDLERINFO.xml' path='doc/member[@name="SYNCMGRHANDLERINFO.wszHandlerName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _wszHandlerName_e__FixedBuffer wszHandlerName;

    /// <include file='_wszHandlerName_e__FixedBuffer.xml' path='doc/member[@name="_wszHandlerName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _wszHandlerName_e__FixedBuffer
    {
        public char e0;
    }
}
