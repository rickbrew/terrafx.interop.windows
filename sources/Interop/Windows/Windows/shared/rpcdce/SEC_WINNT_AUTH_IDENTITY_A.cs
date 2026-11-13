// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A"]/*' />
public unsafe partial struct SEC_WINNT_AUTH_IDENTITY_A
{
    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.User"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* User;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.UserLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint UserLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Domain"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* Domain;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.DomainLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint DomainLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Password"]/*' />
    [NativeTypeName("unsigned char *")]
    public byte* Password;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.PasswordLength"]/*' />
    [NativeTypeName("unsigned long")]
    public uint PasswordLength;

    /// <include file='SEC_WINNT_AUTH_IDENTITY_A.xml' path='doc/member[@name="SEC_WINNT_AUTH_IDENTITY_A.Flags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Flags;
}
