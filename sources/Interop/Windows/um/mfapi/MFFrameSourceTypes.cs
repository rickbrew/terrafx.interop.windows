// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.14393.0")]
    public enum MFFrameSourceTypes
    {
        MFFrameSourceTypes_Color = 0x0001,
        MFFrameSourceTypes_Infrared = 0x0002,
        MFFrameSourceTypes_Depth = 0x0004,
        MFFrameSourceTypes_Image = 0x0008,
        MFFrameSourceTypes_Custom = 0x0080,
    }
}
