// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_PROPERTY_SNI.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY_SNI"]/*' />
public partial struct HTTP_REQUEST_PROPERTY_SNI
{
    /// <include file='HTTP_REQUEST_PROPERTY_SNI.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY_SNI.Hostname"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _Hostname_e__FixedBuffer Hostname;

    /// <include file='HTTP_REQUEST_PROPERTY_SNI.xml' path='doc/member[@name="HTTP_REQUEST_PROPERTY_SNI.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='_Hostname_e__FixedBuffer.xml' path='doc/member[@name="_Hostname_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Hostname_e__FixedBuffer
    {
        public char e0;
    }
}
