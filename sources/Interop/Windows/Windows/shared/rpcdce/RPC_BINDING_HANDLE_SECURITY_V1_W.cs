// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W"]/*' />
public unsafe partial struct RPC_BINDING_HANDLE_SECURITY_V1_W
{
    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.ServerPrincName"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* ServerPrincName;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthnLevel"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthnLevel;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthnSvc"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthnSvc;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.AuthIdentity"]/*' />
    public SEC_WINNT_AUTH_IDENTITY_W* AuthIdentity;

    /// <include file='RPC_BINDING_HANDLE_SECURITY_V1_W.xml' path='doc/member[@name="RPC_BINDING_HANDLE_SECURITY_V1_W.SecurityQos"]/*' />
    public RPC_SECURITY_QOS* SecurityQos;
}
