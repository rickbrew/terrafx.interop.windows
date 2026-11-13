// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_BINDING_VECTOR.xml' path='doc/member[@name="RPC_BINDING_VECTOR"]/*' />
public partial struct RPC_BINDING_VECTOR
{
    /// <include file='RPC_BINDING_VECTOR.xml' path='doc/member[@name="RPC_BINDING_VECTOR.Count"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Count;

    /// <include file='RPC_BINDING_VECTOR.xml' path='doc/member[@name="RPC_BINDING_VECTOR.BindingH"]/*' />
    [NativeTypeName("RPC_BINDING_HANDLE[1]")]
    public _BindingH_e__FixedBuffer BindingH;

    /// <include file='_BindingH_e__FixedBuffer.xml' path='doc/member[@name="_BindingH_e__FixedBuffer"]/*' />
    public unsafe partial struct _BindingH_e__FixedBuffer
    {
        public void* e0;

        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
