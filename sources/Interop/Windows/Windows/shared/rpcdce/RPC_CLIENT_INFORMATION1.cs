// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_CLIENT_INFORMATION1.xml' path='doc/member[@name="RPC_CLIENT_INFORMATION1"]/*' />
public unsafe partial struct RPC_CLIENT_INFORMATION1
{
    /// <include file='RPC_CLIENT_INFORMATION1.xml' path='doc/member[@name="RPC_CLIENT_INFORMATION1.UserName"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* UserName;

    /// <include file='RPC_CLIENT_INFORMATION1.xml' path='doc/member[@name="RPC_CLIENT_INFORMATION1.ComputerName"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* ComputerName;

    /// <include file='RPC_CLIENT_INFORMATION1.xml' path='doc/member[@name="RPC_CLIENT_INFORMATION1.Privilege"]/*' />
    [NativeTypeName("unsigned short")]
    public ushort Privilege;

    /// <include file='RPC_CLIENT_INFORMATION1.xml' path='doc/member[@name="RPC_CLIENT_INFORMATION1.AuthFlags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthFlags;
}
