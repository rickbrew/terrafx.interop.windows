// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W"]/*' />
public unsafe partial struct RPC_BINDING_HANDLE_TEMPLATE_V1_W
{
    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.ProtocolSequence"]/*' />
    [NativeTypeName("unsigned long")]
    public uint ProtocolSequence;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.NetworkAddress"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* NetworkAddress;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.StringEndpoint"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* StringEndpoint;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.u1"]/*' />
    [NativeTypeName("__AnonymousRecord_rpcdce_L2057_C5")]
    public _u1_e__Union u1;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_W.ObjectUuid"]/*' />
    [NativeTypeName("UUID")]
    public Guid ObjectUuid;

    /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u1_e__Union
    {
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("unsigned short *")]
        public ushort* Reserved;
    }
}
