// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A"]/*' />
public unsafe partial struct RPC_BINDING_HANDLE_TEMPLATE_V1_A
{
    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.ProtocolSequence"]/*' />
    [NativeTypeName("unsigned long")]
    public uint ProtocolSequence;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.NetworkAddress"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* NetworkAddress;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.StringEndpoint"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* StringEndpoint;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.u1"]/*' />
    [NativeTypeName("__AnonymousRecord_rpcdce_L2070_C5")]
    public _u1_e__Union u1;

    /// <include file='RPC_BINDING_HANDLE_TEMPLATE_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_TEMPLATE_V1_A.ObjectUuid"]/*' />
    [NativeTypeName("UUID")]
    public Guid ObjectUuid;

    /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u1_e__Union
    {
        /// <include file='_u1_e__Union.xml' path='doc/member[@name="_u1_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("unsigned char *")]
        public byte* Reserved;
    }
}
