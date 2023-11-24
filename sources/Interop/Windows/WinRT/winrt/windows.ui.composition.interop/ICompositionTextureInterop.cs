// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionTextureInterop.xml' path='doc/member[@name="ICompositionTextureInterop"]/*' />
[Guid("D528A265-F0A5-422F-A39D-EF62D7CD1CC4")]
[NativeTypeName("struct ICompositionTextureInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositionTextureInterop : ICompositionTextureInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionTextureInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTextureInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionTextureInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTextureInterop*, uint>)(lpVtbl[1]))((ICompositionTextureInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTextureInterop*, uint>)(lpVtbl[2]))((ICompositionTextureInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionTextureInterop.xml' path='doc/member[@name="ICompositionTextureInterop.GetAvailableFence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailableFence([NativeTypeName("UINT64 *")] ulong* fenceValue, [NativeTypeName("const IID &")] Guid* iid, void** availableFence)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionTextureInterop*, ulong*, Guid*, void**, int>)(lpVtbl[3]))((ICompositionTextureInterop*)Unsafe.AsPointer(ref this), fenceValue, iid, availableFence);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAvailableFence([NativeTypeName("UINT64 *")] ulong* fenceValue, [NativeTypeName("const IID &")] Guid* iid, void** availableFence);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT64 *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, Guid*, void**, int> GetAvailableFence;
    }
}
