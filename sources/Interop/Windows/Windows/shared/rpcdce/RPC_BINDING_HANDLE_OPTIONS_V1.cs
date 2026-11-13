// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_HANDLE_OPTIONS_V1.xml' path='doc/member[@name="RPC_BINDING_HANDLE_OPTIONS_V1"]/*' />
public partial struct RPC_BINDING_HANDLE_OPTIONS_V1
{
    /// <include file='RPC_BINDING_HANDLE_OPTIONS_V1.xml' path='doc/member[@name="RPC_BINDING_HANDLE_OPTIONS_V1.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_BINDING_HANDLE_OPTIONS_V1.xml' path='doc/member[@name="RPC_BINDING_HANDLE_OPTIONS_V1.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;

    /// <include file='RPC_BINDING_HANDLE_OPTIONS_V1.xml' path='doc/member[@name="RPC_BINDING_HANDLE_OPTIONS_V1.ComTimeout"]/*' />
    [NativeTypeName("unsigned long")]
    public uint ComTimeout;

    /// <include file='RPC_BINDING_HANDLE_OPTIONS_V1.xml' path='doc/member[@name="RPC_BINDING_HANDLE_OPTIONS_V1.CallTimeout"]/*' />
    [NativeTypeName("unsigned long")]
    public uint CallTimeout;
}
