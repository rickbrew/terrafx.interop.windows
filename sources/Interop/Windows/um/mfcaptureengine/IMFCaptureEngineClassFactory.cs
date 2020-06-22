// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8F02D140-56FC-4302-A705-3A97C78BE779")]
    public unsafe partial struct IMFCaptureEngineClassFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCaptureEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCaptureEngineClassFactory*, uint>)(lpVtbl[1]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCaptureEngineClassFactory*, uint>)(lpVtbl[2]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCaptureEngineClassFactory*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this), clsid, riid, ppvObject);
        }
    }
}
