// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR"]/*' />
public partial struct RPC_IF_ID_VECTOR
{
    /// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR.Count"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Count;

    /// <include file='RPC_IF_ID_VECTOR.xml' path='doc/member[@name="RPC_IF_ID_VECTOR.IfId"]/*' />
    [NativeTypeName("RPC_IF_ID *[1]")]
    public _IfId_e__FixedBuffer IfId;

    /// <include file='_IfId_e__FixedBuffer.xml' path='doc/member[@name="_IfId_e__FixedBuffer"]/*' />
    public unsafe partial struct _IfId_e__FixedBuffer
    {
        public RPC_IF_ID* e0;

        public ref RPC_IF_ID* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (RPC_IF_ID** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
