// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_STATS_VECTOR.xml' path='doc/member[@name="RPC_STATS_VECTOR"]/*' />
public partial struct RPC_STATS_VECTOR
{
    /// <include file='RPC_STATS_VECTOR.xml' path='doc/member[@name="RPC_STATS_VECTOR.Count"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Count;

    /// <include file='RPC_STATS_VECTOR.xml' path='doc/member[@name="RPC_STATS_VECTOR.Stats"]/*' />
    [NativeTypeName("unsigned long[1]")]
    public _Stats_e__FixedBuffer Stats;

    /// <include file='_Stats_e__FixedBuffer.xml' path='doc/member[@name="_Stats_e__FixedBuffer"]/*' />
    public partial struct _Stats_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
