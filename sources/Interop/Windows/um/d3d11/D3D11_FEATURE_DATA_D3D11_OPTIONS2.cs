// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
    {
        public BOOL PSSpecifiedStencilRefSupported;

        public BOOL TypedUAVLoadAdditionalFormats;

        public BOOL ROVsSupported;

        public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

        public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

        public BOOL MapOnDefaultTextures;

        public BOOL StandardSwizzle;

        public BOOL UnifiedMemoryArchitecture;
    }
}
