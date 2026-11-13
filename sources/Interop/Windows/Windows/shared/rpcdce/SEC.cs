// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SEC
{
    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_WINNT_AUTH_IDENTITY_ANSI"]/*' />
    [NativeTypeName("#define SEC_WINNT_AUTH_IDENTITY_ANSI 0x1")]
    public const int SEC_WINNT_AUTH_IDENTITY_ANSI = 0x1;

    /// <include file='SEC.xml' path='doc/member[@name="SEC.SEC_WINNT_AUTH_IDENTITY_UNICODE"]/*' />
    [NativeTypeName("#define SEC_WINNT_AUTH_IDENTITY_UNICODE 0x2")]
    public const int SEC_WINNT_AUTH_IDENTITY_UNICODE = 0x2;
}
