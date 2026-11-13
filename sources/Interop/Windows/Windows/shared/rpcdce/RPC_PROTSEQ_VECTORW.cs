// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW"]/*' />
public partial struct RPC_PROTSEQ_VECTORW
{
    /// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW.Count"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Count;

    /// <include file='RPC_PROTSEQ_VECTORW.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORW.Protseq"]/*' />
    [NativeTypeName("unsigned short *[1]")]
    public _Protseq_e__FixedBuffer Protseq;

    /// <include file='_Protseq_e__FixedBuffer.xml' path='doc/member[@name="_Protseq_e__FixedBuffer"]/*' />
    public unsafe partial struct _Protseq_e__FixedBuffer
    {
        public ushort* e0;

        public ref ushort* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (ushort** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
