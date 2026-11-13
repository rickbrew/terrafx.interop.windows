// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='UUID_VECTOR.xml' path='doc/member[@name="UUID_VECTOR"]/*' />
public partial struct UUID_VECTOR
{
    /// <include file='UUID_VECTOR.xml' path='doc/member[@name="UUID_VECTOR.Count"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Count;

    /// <include file='UUID_VECTOR.xml' path='doc/member[@name="UUID_VECTOR.Uuid"]/*' />
    [NativeTypeName("UUID *[1]")]
    public _Uuid_e__FixedBuffer Uuid;

    /// <include file='_Uuid_e__FixedBuffer.xml' path='doc/member[@name="_Uuid_e__FixedBuffer"]/*' />
    public unsafe partial struct _Uuid_e__FixedBuffer
    {
        public Guid* e0;

        public ref Guid* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (Guid** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
