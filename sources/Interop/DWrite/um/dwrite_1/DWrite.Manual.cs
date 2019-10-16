// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class DWrite
    {
        public static readonly Guid IID_IDWriteFactory1 = new Guid(0x30572F99, 0xDAC6, 0x41DB, 0xA1, 0x6E, 0x04, 0x86, 0x30, 0x7E, 0x60, 0x6A);

        public static readonly Guid IID_IDWriteFontFace1 = new Guid(0xA71EFDB4, 0x9FDB, 0x4838, 0xAD, 0x90, 0xCF, 0xC3, 0xBE, 0x8C, 0x3D, 0xAF);

        public static readonly Guid IID_IDWriteFont1 = new Guid(0xACD16696, 0x8C14, 0x4F5D, 0x87, 0x7E, 0xFE, 0x3F, 0xC1, 0xD3, 0x27, 0x38);

        public static readonly Guid IID_IDWriteRenderingParams1 = new Guid(0x94413CF4, 0xA6FC, 0x4248, 0x8B, 0x50, 0x66, 0x74, 0x34, 0x8F, 0xCA, 0xD3);

        public static readonly Guid IID_IDWriteTextAnalyzer1 = new Guid(0x80DAD800, 0xE21F, 0x4E83, 0x96, 0xCE, 0xBF, 0xCC, 0xE5, 0x00, 0xDB, 0x7C);

        public static readonly Guid IID_IDWriteTextAnalysisSource1 = new Guid(0x639CFAD8, 0x0FB4, 0x4B21, 0xA5, 0x8A, 0x06, 0x79, 0x20, 0x12, 0x00, 0x09);

        public static readonly Guid IID_IDWriteTextAnalysisSink1 = new Guid(0xB0D941A0, 0x85E7, 0x4D8B, 0x9F, 0xD3, 0x5C, 0xED, 0x99, 0x34, 0x48, 0x2A);

        public static readonly Guid IID_IDWriteTextLayout1 = new Guid(0x9064D822, 0x80A7, 0x465C, 0xA9, 0x86, 0xDF, 0x65, 0xF7, 0x8B, 0x8F, 0xEB);

        public static readonly Guid IID_IDWriteBitmapRenderTarget1 = new Guid(0x791E8298, 0x3EF3, 0x4230, 0x98, 0x80, 0xC9, 0xBD, 0xEC, 0xC4, 0x20, 0x64);
    }
}