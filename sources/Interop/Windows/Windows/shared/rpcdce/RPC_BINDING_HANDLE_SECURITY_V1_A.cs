// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A"]/*' />
public unsafe partial struct RPC_BINDING_HANDLE_SECURITY_V1_A
{
    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.ServerPrincName"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* ServerPrincName;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.AuthnLevel"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthnLevel;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.AuthnSvc"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthnSvc;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.AuthIdentity"]/*' />
    public SEC_WINNT_AUTH_IDENTITY_A* AuthIdentity;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_A.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_A.SecurityQos"]/*' />
    public RPC_SECURITY_QOS* SecurityQos;
}
