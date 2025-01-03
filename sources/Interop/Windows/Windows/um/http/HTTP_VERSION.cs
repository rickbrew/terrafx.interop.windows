// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_VERSION.xml' path='doc/member[@name="HTTP_VERSION"]/*' />
public partial struct HTTP_VERSION
{
    /// <include file='HTTP_VERSION.xml' path='doc/member[@name="HTTP_VERSION.MajorVersion"]/*' />
    public ushort MajorVersion;

    /// <include file='HTTP_VERSION.xml' path='doc/member[@name="HTTP_VERSION.MinorVersion"]/*' />
    public ushort MinorVersion;
}
