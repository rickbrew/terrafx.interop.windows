// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W"]/*' />
public unsafe partial struct SEC_WINNT_AUTH_IDENTITY_W
{
    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.User"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* User;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.UserLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint UserLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.Domain"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* Domain;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.DomainLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint DomainLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.Password"]/*' />
    [NativeTypeName("unsigned short *")]
    public ushort* Password;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.PasswordLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint PasswordLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_W.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_W.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;
}
