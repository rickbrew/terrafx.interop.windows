// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IAdviseSinkEx = new Guid(0x3AF24290, 0x0C96, 0x11CE, 0xA0, 0xCF, 0x00, 0xAA, 0x00, 0x60, 0x0A, 0xB8);

        public static readonly Guid IID_IClassFactory2 = new Guid(0xB196B28F, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IConnectionPoint = new Guid(0xB196B286, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IConnectionPointContainer = new Guid(0xB196B284, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IEnumConnectionPoints = new Guid(0xB196B285, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IEnumConnections = new Guid(0xB196B287, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IEnumOleUndoUnits = new Guid(0xB3E7C340, 0xEF97, 0x11CE, 0x9B, 0xC9, 0x00, 0xAA, 0x00, 0x60, 0x8E, 0x01);

        public static readonly Guid IID_IFont = new Guid(0xBEF6E002, 0xA874, 0x101A, 0x8B, 0xBA, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        public static readonly Guid IID_IFontDisp = new Guid(0xBEF6E003, 0xA874, 0x101A, 0x8B, 0xBA, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        public static readonly Guid IID_IFontEventsDisp = new Guid(0x4EF6100A, 0xAF88, 0x11D0, 0x98, 0x46, 0x00, 0xC0, 0x4F, 0xC2, 0x99, 0x93);

        public static readonly Guid IID_IObjectWithSite = new Guid(0xFC4801A3, 0x2BA9, 0x11CF, 0xA2, 0x29, 0x00, 0xAA, 0x00, 0x3D, 0x73, 0x52);

        public static readonly Guid IID_IOleControl = new Guid(0xB196B288, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IOleControlSite = new Guid(0xB196B289, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IOleInPlaceObjectWindowless = new Guid(0x1C2056CC, 0x5EF4, 0x101B, 0x8B, 0xC8, 0x00, 0xAA, 0x00, 0x3E, 0x3B, 0x29);

        public static readonly Guid IID_IOleInPlaceSiteEx = new Guid(0x9C2CAD80, 0x3424, 0x11CF, 0xB6, 0x70, 0x00, 0xAA, 0x00, 0x4C, 0xD6, 0xD8);

        public static readonly Guid IID_IOleInPlaceSiteWindowless = new Guid(0x922EADA0, 0x3424, 0x11CF, 0xB6, 0x70, 0x00, 0xAA, 0x00, 0x4C, 0xD6, 0xD8);

        public static readonly Guid IID_IOleParentUndoUnit = new Guid(0xA1FAF330, 0xEF97, 0x11CE, 0x9B, 0xC9, 0x00, 0xAA, 0x00, 0x60, 0x8E, 0x01);

        public static readonly Guid IID_IOleUndoManager = new Guid(0xD001F200, 0xEF97, 0x11CE, 0x9B, 0xC9, 0x00, 0xAA, 0x00, 0x60, 0x8E, 0x01);

        public static readonly Guid IID_IOleUndoUnit = new Guid(0x894AD3B0, 0xEF97, 0x11CE, 0x9B, 0xC9, 0x00, 0xAA, 0x00, 0x60, 0x8E, 0x01);

        public static readonly Guid IID_IPerPropertyBrowsing = new Guid(0x376BD3AA, 0x3845, 0x101B, 0x84, 0xED, 0x08, 0x00, 0x2B, 0x2E, 0xC7, 0x13);

        public static readonly Guid IID_IPersistMemory = new Guid(0xBD1AE5E0, 0xA6AE, 0x11CE, 0xBD, 0x37, 0x50, 0x42, 0x00, 0xC1, 0x00, 0x00);

        public static readonly Guid IID_IPersistPropertyBag = new Guid(0x37D84F60, 0x42CB, 0x11CE, 0x81, 0x35, 0x00, 0xAA, 0x00, 0x4B, 0xB8, 0x51);

        public static readonly Guid IID_IPersistPropertyBag2 = new Guid(0x22F55881, 0x280B, 0x11D0, 0xA8, 0xA9, 0x00, 0xA0, 0xC9, 0x0C, 0x20, 0x04);

        public static readonly Guid IID_IPersistStreamInit = new Guid(0x7FD52380, 0x4E07, 0x101B, 0xAE, 0x2D, 0x08, 0x00, 0x2B, 0x2E, 0xC7, 0x13);

        public static readonly Guid IID_IPicture = new Guid(0x7BF80980, 0xBF32, 0x101A, 0x8B, 0xBB, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        public static readonly Guid IID_IPicture2 = new Guid(0xF5185DD8, 0x2012, 0x4B0B, 0xAA, 0xD9, 0xF0, 0x52, 0xC6, 0xBD, 0x48, 0x2B);

        public static readonly Guid IID_IPictureDisp = new Guid(0x7BF80981, 0xBF32, 0x101A, 0x8B, 0xBB, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        public static readonly Guid IID_IPointerInactive = new Guid(0x55980BA0, 0x35AA, 0x11CF, 0xB6, 0x71, 0x00, 0xAA, 0x00, 0x4C, 0xD6, 0xD8);

        public static readonly Guid IID_IPropertyBag2 = new Guid(0x22F55882, 0x280B, 0x11D0, 0xA8, 0xA9, 0x00, 0xA0, 0xC9, 0x0C, 0x20, 0x04);

        public static readonly Guid IID_IPropertyNotifySink = new Guid(0x9BFBBC02, 0xEFF1, 0x101A, 0x84, 0xED, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IPropertyPage = new Guid(0xB196B28D, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IPropertyPage2 = new Guid(0x01E44665, 0x24AC, 0x101B, 0x84, 0xED, 0x08, 0x00, 0x2B, 0x2E, 0xC7, 0x13);

        public static readonly Guid IID_IPropertyPageSite = new Guid(0xB196B28C, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IProvideClassInfo = new Guid(0xB196B283, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IProvideClassInfo2 = new Guid(0xA6BC3AC0, 0xDBAA, 0x11CE, 0x9D, 0xE3, 0x00, 0xAA, 0x00, 0x4B, 0xB8, 0x51);

        public static readonly Guid IID_IProvideMultipleClassInfo = new Guid(0xA7ABA9C1, 0x8983, 0x11CF, 0x8F, 0x20, 0x00, 0x80, 0x5F, 0x2C, 0xD0, 0x64);

        public static readonly Guid IID_IQuickActivate = new Guid(0xCF51ED10, 0x62FE, 0x11CF, 0xBF, 0x86, 0x00, 0xA0, 0xC9, 0x03, 0x48, 0x36);

        public static readonly Guid IID_ISimpleFrameSite = new Guid(0x742B0E01, 0x14E6, 0x101B, 0x91, 0x4E, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        public static readonly Guid IID_ISpecifyPropertyPages = new Guid(0xB196B28B, 0xBAB4, 0x101A, 0xB6, 0x9C, 0x00, 0xAA, 0x00, 0x34, 0x1D, 0x07);

        public static readonly Guid IID_IViewObjectEx = new Guid(0x3AF24292, 0x0C96, 0x11CE, 0xA0, 0xCF, 0x00, 0xAA, 0x00, 0x60, 0x0A, 0xB8);
    }
}
