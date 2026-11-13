// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A"]/*' />
public unsafe partial struct RPC_SECURITY_QOS_V4_A
{
    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.Capabilities"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Capabilities;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.IdentityTracking"]/*' />
    [NativeTypeName("unsigned long")]
    public uint IdentityTracking;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.ImpersonationType"]/*' />
    [NativeTypeName("unsigned long")]
    public uint ImpersonationType;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.AdditionalSecurityInfoType"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AdditionalSecurityInfoType;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.u"]/*' />
    [NativeTypeName("__AnonymousRecord_rpcdce_L1893_C3")]
    public _u_e__Union u;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.Sid"]/*' />
    public void* Sid;

    /// <include file='RPC_SECURITY_QOS_V4_A.xml' path='doc/member[@name="RPC_SECURITY_QOS_V4_A.EffectiveOnly"]/*' />
    [NativeTypeName("unsigned int")]
    public uint EffectiveOnly;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.HttpCredentials"]/*' />
        [FieldOffset(0)]
        public RPC_HTTP_TRANSPORT_CREDENTIALS_A* HttpCredentials;
    }
}
