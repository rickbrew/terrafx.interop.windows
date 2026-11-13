// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A"]/*' />
public unsafe partial struct RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A
{
    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.TransportCredentials"]/*' />
    public SEC_WINNT_AUTH_IDENTITY_A* TransportCredentials;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.AuthenticationTarget"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthenticationTarget;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.NumberOfAuthnSchemes"]/*' />
    [NativeTypeName("unsigned long")]
    public uint NumberOfAuthnSchemes;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.AuthnSchemes"]/*' />
    [NativeTypeName("unsigned long *")]
    public uint* AuthnSchemes;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.ServerCertificateSubject"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* ServerCertificateSubject;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.ProxyCredentials"]/*' />
    public SEC_WINNT_AUTH_IDENTITY_A* ProxyCredentials;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.NumberOfProxyAuthnSchemes"]/*' />
    [NativeTypeName("unsigned long")]
    public uint NumberOfProxyAuthnSchemes;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_V2_A.ProxyAuthnSchemes"]/*' />
    [NativeTypeName("unsigned long *")]
    public uint* ProxyAuthnSchemes;
}
