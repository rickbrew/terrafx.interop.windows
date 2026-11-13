// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_PROTSEQ_VECTORA.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORA"]/*' />
public partial struct RPC_PROTSEQ_VECTORA
{
    /// <include file='RPC_PROTSEQ_VECTORA.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORA.Count"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Count;

    /// <include file='RPC_PROTSEQ_VECTORA.xml' path='doc/member[@name="RPC_PROTSEQ_VECTORA.Protseq"]/*' />
    [NativeTypeName("unsigned char *[1]")]
    public _Protseq_e__FixedBuffer Protseq;

    /// <include file='_Protseq_e__FixedBuffer.xml' path='doc/member[@name="_Protseq_e__FixedBuffer"]/*' />
    public unsafe partial struct _Protseq_e__FixedBuffer
    {
        public byte* e0;

        public ref byte* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (byte** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
