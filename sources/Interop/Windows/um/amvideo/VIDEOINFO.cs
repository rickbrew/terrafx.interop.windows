// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct VIDEOINFO
    {
        public RECT rcSource;

        public RECT rcTarget;

        [NativeTypeName("DWORD")]
        public uint dwBitRate;

        [NativeTypeName("DWORD")]
        public uint dwBitErrorRate;

        [NativeTypeName("REFERENCE_TIME")]
        public long AvgTimePerFrame;

        public BITMAPINFOHEADER bmiHeader;

        [NativeTypeName("tagVIDEOINFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/amvideo.h:319:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("RGBQUAD [256]")]
            public _bmiColors_e__FixedBuffer bmiColors;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [3]")]
            public fixed uint dwBitMasks[3];

            [FieldOffset(0)]
            public TRUECOLORINFO TrueColorInfo;

            public partial struct _bmiColors_e__FixedBuffer
            {
                internal RGBQUAD e0;
                internal RGBQUAD e1;
                internal RGBQUAD e2;
                internal RGBQUAD e3;
                internal RGBQUAD e4;
                internal RGBQUAD e5;
                internal RGBQUAD e6;
                internal RGBQUAD e7;
                internal RGBQUAD e8;
                internal RGBQUAD e9;
                internal RGBQUAD e10;
                internal RGBQUAD e11;
                internal RGBQUAD e12;
                internal RGBQUAD e13;
                internal RGBQUAD e14;
                internal RGBQUAD e15;
                internal RGBQUAD e16;
                internal RGBQUAD e17;
                internal RGBQUAD e18;
                internal RGBQUAD e19;
                internal RGBQUAD e20;
                internal RGBQUAD e21;
                internal RGBQUAD e22;
                internal RGBQUAD e23;
                internal RGBQUAD e24;
                internal RGBQUAD e25;
                internal RGBQUAD e26;
                internal RGBQUAD e27;
                internal RGBQUAD e28;
                internal RGBQUAD e29;
                internal RGBQUAD e30;
                internal RGBQUAD e31;
                internal RGBQUAD e32;
                internal RGBQUAD e33;
                internal RGBQUAD e34;
                internal RGBQUAD e35;
                internal RGBQUAD e36;
                internal RGBQUAD e37;
                internal RGBQUAD e38;
                internal RGBQUAD e39;
                internal RGBQUAD e40;
                internal RGBQUAD e41;
                internal RGBQUAD e42;
                internal RGBQUAD e43;
                internal RGBQUAD e44;
                internal RGBQUAD e45;
                internal RGBQUAD e46;
                internal RGBQUAD e47;
                internal RGBQUAD e48;
                internal RGBQUAD e49;
                internal RGBQUAD e50;
                internal RGBQUAD e51;
                internal RGBQUAD e52;
                internal RGBQUAD e53;
                internal RGBQUAD e54;
                internal RGBQUAD e55;
                internal RGBQUAD e56;
                internal RGBQUAD e57;
                internal RGBQUAD e58;
                internal RGBQUAD e59;
                internal RGBQUAD e60;
                internal RGBQUAD e61;
                internal RGBQUAD e62;
                internal RGBQUAD e63;
                internal RGBQUAD e64;
                internal RGBQUAD e65;
                internal RGBQUAD e66;
                internal RGBQUAD e67;
                internal RGBQUAD e68;
                internal RGBQUAD e69;
                internal RGBQUAD e70;
                internal RGBQUAD e71;
                internal RGBQUAD e72;
                internal RGBQUAD e73;
                internal RGBQUAD e74;
                internal RGBQUAD e75;
                internal RGBQUAD e76;
                internal RGBQUAD e77;
                internal RGBQUAD e78;
                internal RGBQUAD e79;
                internal RGBQUAD e80;
                internal RGBQUAD e81;
                internal RGBQUAD e82;
                internal RGBQUAD e83;
                internal RGBQUAD e84;
                internal RGBQUAD e85;
                internal RGBQUAD e86;
                internal RGBQUAD e87;
                internal RGBQUAD e88;
                internal RGBQUAD e89;
                internal RGBQUAD e90;
                internal RGBQUAD e91;
                internal RGBQUAD e92;
                internal RGBQUAD e93;
                internal RGBQUAD e94;
                internal RGBQUAD e95;
                internal RGBQUAD e96;
                internal RGBQUAD e97;
                internal RGBQUAD e98;
                internal RGBQUAD e99;
                internal RGBQUAD e100;
                internal RGBQUAD e101;
                internal RGBQUAD e102;
                internal RGBQUAD e103;
                internal RGBQUAD e104;
                internal RGBQUAD e105;
                internal RGBQUAD e106;
                internal RGBQUAD e107;
                internal RGBQUAD e108;
                internal RGBQUAD e109;
                internal RGBQUAD e110;
                internal RGBQUAD e111;
                internal RGBQUAD e112;
                internal RGBQUAD e113;
                internal RGBQUAD e114;
                internal RGBQUAD e115;
                internal RGBQUAD e116;
                internal RGBQUAD e117;
                internal RGBQUAD e118;
                internal RGBQUAD e119;
                internal RGBQUAD e120;
                internal RGBQUAD e121;
                internal RGBQUAD e122;
                internal RGBQUAD e123;
                internal RGBQUAD e124;
                internal RGBQUAD e125;
                internal RGBQUAD e126;
                internal RGBQUAD e127;
                internal RGBQUAD e128;
                internal RGBQUAD e129;
                internal RGBQUAD e130;
                internal RGBQUAD e131;
                internal RGBQUAD e132;
                internal RGBQUAD e133;
                internal RGBQUAD e134;
                internal RGBQUAD e135;
                internal RGBQUAD e136;
                internal RGBQUAD e137;
                internal RGBQUAD e138;
                internal RGBQUAD e139;
                internal RGBQUAD e140;
                internal RGBQUAD e141;
                internal RGBQUAD e142;
                internal RGBQUAD e143;
                internal RGBQUAD e144;
                internal RGBQUAD e145;
                internal RGBQUAD e146;
                internal RGBQUAD e147;
                internal RGBQUAD e148;
                internal RGBQUAD e149;
                internal RGBQUAD e150;
                internal RGBQUAD e151;
                internal RGBQUAD e152;
                internal RGBQUAD e153;
                internal RGBQUAD e154;
                internal RGBQUAD e155;
                internal RGBQUAD e156;
                internal RGBQUAD e157;
                internal RGBQUAD e158;
                internal RGBQUAD e159;
                internal RGBQUAD e160;
                internal RGBQUAD e161;
                internal RGBQUAD e162;
                internal RGBQUAD e163;
                internal RGBQUAD e164;
                internal RGBQUAD e165;
                internal RGBQUAD e166;
                internal RGBQUAD e167;
                internal RGBQUAD e168;
                internal RGBQUAD e169;
                internal RGBQUAD e170;
                internal RGBQUAD e171;
                internal RGBQUAD e172;
                internal RGBQUAD e173;
                internal RGBQUAD e174;
                internal RGBQUAD e175;
                internal RGBQUAD e176;
                internal RGBQUAD e177;
                internal RGBQUAD e178;
                internal RGBQUAD e179;
                internal RGBQUAD e180;
                internal RGBQUAD e181;
                internal RGBQUAD e182;
                internal RGBQUAD e183;
                internal RGBQUAD e184;
                internal RGBQUAD e185;
                internal RGBQUAD e186;
                internal RGBQUAD e187;
                internal RGBQUAD e188;
                internal RGBQUAD e189;
                internal RGBQUAD e190;
                internal RGBQUAD e191;
                internal RGBQUAD e192;
                internal RGBQUAD e193;
                internal RGBQUAD e194;
                internal RGBQUAD e195;
                internal RGBQUAD e196;
                internal RGBQUAD e197;
                internal RGBQUAD e198;
                internal RGBQUAD e199;
                internal RGBQUAD e200;
                internal RGBQUAD e201;
                internal RGBQUAD e202;
                internal RGBQUAD e203;
                internal RGBQUAD e204;
                internal RGBQUAD e205;
                internal RGBQUAD e206;
                internal RGBQUAD e207;
                internal RGBQUAD e208;
                internal RGBQUAD e209;
                internal RGBQUAD e210;
                internal RGBQUAD e211;
                internal RGBQUAD e212;
                internal RGBQUAD e213;
                internal RGBQUAD e214;
                internal RGBQUAD e215;
                internal RGBQUAD e216;
                internal RGBQUAD e217;
                internal RGBQUAD e218;
                internal RGBQUAD e219;
                internal RGBQUAD e220;
                internal RGBQUAD e221;
                internal RGBQUAD e222;
                internal RGBQUAD e223;
                internal RGBQUAD e224;
                internal RGBQUAD e225;
                internal RGBQUAD e226;
                internal RGBQUAD e227;
                internal RGBQUAD e228;
                internal RGBQUAD e229;
                internal RGBQUAD e230;
                internal RGBQUAD e231;
                internal RGBQUAD e232;
                internal RGBQUAD e233;
                internal RGBQUAD e234;
                internal RGBQUAD e235;
                internal RGBQUAD e236;
                internal RGBQUAD e237;
                internal RGBQUAD e238;
                internal RGBQUAD e239;
                internal RGBQUAD e240;
                internal RGBQUAD e241;
                internal RGBQUAD e242;
                internal RGBQUAD e243;
                internal RGBQUAD e244;
                internal RGBQUAD e245;
                internal RGBQUAD e246;
                internal RGBQUAD e247;
                internal RGBQUAD e248;
                internal RGBQUAD e249;
                internal RGBQUAD e250;
                internal RGBQUAD e251;
                internal RGBQUAD e252;
                internal RGBQUAD e253;
                internal RGBQUAD e254;
                internal RGBQUAD e255;

                public ref RGBQUAD this[int index] => ref AsSpan()[index];

                public Span<RGBQUAD> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 256);
            }
        }
    }
}
