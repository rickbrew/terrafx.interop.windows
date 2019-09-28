// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
    {
        [NativeTypeName("UINT64")]
        public ulong pixelRate;

        public DISPLAYCONFIG_RATIONAL hSyncFreq;

        public DISPLAYCONFIG_RATIONAL vSyncFreq;

        public DISPLAYCONFIG_2DREGION activeSize;

        public DISPLAYCONFIG_2DREGION totalSize;

        [NativeTypeName("struct (anonymous struct at um/wingdi.h:2850:5)")]
        public _Anonymous_e__Union Anonymous;

        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at um/wingdi.h:2852:9)")]
            public _AdditionalSignalInfo_e__Union AdditionalSignalInfo;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint videoStandard;

            public partial struct _AdditionalSignalInfo_e__Union
            {
                internal uint _bitfield;

                [NativeTypeName("UINT32")]
                public uint videoStandard
                {
                    get
                    {
                        return _bitfield & 0xFFFF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFF);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint vSyncFreqDivider
                {
                    get
                    {
                        return (_bitfield >> 16) & 0x3F;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3F) << 16);
                    }
                }

                [NativeTypeName("UINT32")]
                public uint reserved
                {
                    get
                    {
                        return (_bitfield >> 22) & 0x3FF;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FF) << 22);
                    }
                }
            }
        }
    }
}
