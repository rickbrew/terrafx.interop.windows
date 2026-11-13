// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W"]/*' />
public unsafe partial struct RPC_HTTP_TRANSPORT_CREDENTIALS_W
{
    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.TransportCredentials"]/*' />
    public SEC_WINNT_AUTH_IDENTITY_W* TransportCredentials;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.AuthenticationTarget"]/*' />
    [NativeTypeName("unsigned long")]
    public uint AuthenticationTarget;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.NumberOfAuthnSchemes"]/*' />
    [NativeTypeName("unsigned long")]
    public uint NumberOfAuthnSchemes;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.AuthnSchemes"]/*' />
    [NativeTypeName("unsigned long *")]
    public uint* AuthnSchemes;

    /// <include file='RPC_HTTP_TRANSPORT_CREDENTIALS_W.xml' path='doc/member[@name="RPC_HTTP_TRANSPORT_CREDENTIALS_W.ServerCertificateSubject"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* ServerCertificateSubject;
}
