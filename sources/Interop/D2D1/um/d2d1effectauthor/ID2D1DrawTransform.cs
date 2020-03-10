// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36BFDCB6-9739-435D-A30D-A653BEFF6A6F")]
    public unsafe partial struct ID2D1DrawTransform
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DrawTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DrawTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DrawTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1DrawTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapOutputRectToInputRects(ID2D1DrawTransform* pThis, [NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapInputRectsToOutputRect(ID2D1DrawTransform* pThis, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapInvalidRect(ID2D1DrawTransform* pThis, [NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDrawInfo(ID2D1DrawTransform* pThis, [NativeTypeName("ID2D1DrawInfo *")] ID2D1DrawInfo* drawInfo);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapOutputRectToInputRects>(lpVtbl->MapOutputRectToInputRects)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapInputRectsToOutputRect>(lpVtbl->MapInputRectsToOutputRect)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_MapInvalidRect>(lpVtbl->MapInvalidRect)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawInfo([NativeTypeName("ID2D1DrawInfo *")] ID2D1DrawInfo* drawInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDrawInfo>(lpVtbl->SetDrawInfo)((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), drawInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetInputCount;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, D2D1_RECT_L *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MapOutputRectToInputRects;

            [NativeTypeName("HRESULT (const D2D1_RECT_L *, const D2D1_RECT_L *, UINT32, D2D1_RECT_L *, D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MapInputRectsToOutputRect;

            [NativeTypeName("HRESULT (UINT32, D2D1_RECT_L, D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr MapInvalidRect;

            [NativeTypeName("HRESULT (ID2D1DrawInfo *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDrawInfo;
        }
    }
}
