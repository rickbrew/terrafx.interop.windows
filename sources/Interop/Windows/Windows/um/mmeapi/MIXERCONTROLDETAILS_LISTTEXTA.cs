// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCONTROLDETAILS_LISTTEXTA.xml' path='doc/member[@name="MIXERCONTROLDETAILS_LISTTEXTA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS_LISTTEXTA
{
    /// <include file='MIXERCONTROLDETAILS_LISTTEXTA.xml' path='doc/member[@name="MIXERCONTROLDETAILS_LISTTEXTA.dwParam1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwParam1;

    /// <include file='MIXERCONTROLDETAILS_LISTTEXTA.xml' path='doc/member[@name="MIXERCONTROLDETAILS_LISTTEXTA.dwParam2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwParam2;

    /// <include file='MIXERCONTROLDETAILS_LISTTEXTA.xml' path='doc/member[@name="MIXERCONTROLDETAILS_LISTTEXTA.szName"]/*' />
    [NativeTypeName("CHAR[64]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
