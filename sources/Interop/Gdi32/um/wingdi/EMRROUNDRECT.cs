// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct EMRROUNDRECT
    {
        public EMR emr;

        public RECTL rclBox;

        public SIZE szlCorner;
    }
}
