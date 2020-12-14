// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("98EFF3A5-B667-479A-B145-E2FA5B9FDC29")]
    [NativeTypeName("struct IDWriteFontFace5 : IDWriteFontFace4")]
    public unsafe partial struct IDWriteFontFace5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[1]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[2]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_FACE_TYPE>)(lpVtbl[3]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFiles)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[5]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[6]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[7]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_METRICS*, void>)(lpVtbl[8]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort>)(lpVtbl[9]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[10]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, [NativeTypeName("void **")] void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, void**, uint*, void**, int*, int>)(lpVtbl[12]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseFontTable([NativeTypeName("void *")] void* tableContext)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, void*, void>)(lpVtbl[13]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), tableContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, int, int, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int>)(lpVtbl[15]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int>)(lpVtbl[16]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, DWRITE_MATRIX*, int, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int>)(lpVtbl[17]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[18]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int>)(lpVtbl[19]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetCaretMetrics([NativeTypeName("DWRITE_CARET_METRICS *")] DWRITE_CARET_METRICS* caretMetrics)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_CARET_METRICS*, void>)(lpVtbl[20]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), caretMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[22]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, ushort*, int*, int, int>)(lpVtbl[23]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, DWRITE_MATRIX*, int, int, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[26]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int>)(lpVtbl[27]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[29]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[30]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetColorPaletteCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[31]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetPaletteEntryCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[32]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, uint, uint, DXGI_RGBA*, int>)(lpVtbl[33]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode, [NativeTypeName("DWRITE_GRID_FIT_MODE *")] DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[34]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPanose([NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_PANOSE*, void>)(lpVtbl[36]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), panose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_WEIGHT>)(lpVtbl[37]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_STRETCH>)(lpVtbl[38]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_STYLE>)(lpVtbl[39]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[42]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, int>)(lpVtbl[43]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE1 *")] DWRITE_RENDERING_MODE1* renderingMode, [NativeTypeName("DWRITE_GRID_FIT_MODE *")] DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[44]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint, int>)(lpVtbl[45]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort, int>)(lpVtbl[46]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreCharactersLocal([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort*, uint, int, int*, int>)(lpVtbl[47]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort*, uint, int, int*, int>)(lpVtbl[48]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_GLYPH_IMAGE_FORMATS>)(lpVtbl[49]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageFormats([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEmFirst, [NativeTypeName("UINT32")] uint pixelsPerEmLast, [NativeTypeName("DWRITE_GLYPH_IMAGE_FORMATS *")] DWRITE_GLYPH_IMAGE_FORMATS* glyphImageFormats)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort, uint, uint, DWRITE_GLYPH_IMAGE_FORMATS*, int>)(lpVtbl[50]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageData([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("DWRITE_GLYPH_IMAGE_DATA *")] DWRITE_GLYPH_IMAGE_DATA* glyphData, [NativeTypeName("void **")] void** glyphDataContext)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, ushort, uint, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA*, void**, int>)(lpVtbl[51]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseGlyphImageData([NativeTypeName("void *")] void* glyphDataContext)
        {
            ((delegate* unmanaged<IDWriteFontFace5*, void*, void>)(lpVtbl[52]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphDataContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisValueCount()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, uint>)(lpVtbl[53]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[54]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasVariations()
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, int>)(lpVtbl[55]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontResource([NativeTypeName("IDWriteFontResource **")] IDWriteFontResource** fontResource)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFace5*, IDWriteFontFace*, int>)(lpVtbl[57]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFace);
        }
    }
}
