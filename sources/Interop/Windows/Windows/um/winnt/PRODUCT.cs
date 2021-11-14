// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class PRODUCT
    {
        [NativeTypeName("#define PRODUCT_UNDEFINED 0x00000000")]
        public const int PRODUCT_UNDEFINED = 0x00000000;

        [NativeTypeName("#define PRODUCT_ULTIMATE 0x00000001")]
        public const int PRODUCT_ULTIMATE = 0x00000001;

        [NativeTypeName("#define PRODUCT_HOME_BASIC 0x00000002")]
        public const int PRODUCT_HOME_BASIC = 0x00000002;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM 0x00000003")]
        public const int PRODUCT_HOME_PREMIUM = 0x00000003;

        [NativeTypeName("#define PRODUCT_ENTERPRISE 0x00000004")]
        public const int PRODUCT_ENTERPRISE = 0x00000004;

        [NativeTypeName("#define PRODUCT_HOME_BASIC_N 0x00000005")]
        public const int PRODUCT_HOME_BASIC_N = 0x00000005;

        [NativeTypeName("#define PRODUCT_BUSINESS 0x00000006")]
        public const int PRODUCT_BUSINESS = 0x00000006;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER 0x00000007")]
        public const int PRODUCT_STANDARD_SERVER = 0x00000007;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER 0x00000008")]
        public const int PRODUCT_DATACENTER_SERVER = 0x00000008;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER 0x00000009")]
        public const int PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER 0x0000000A")]
        public const int PRODUCT_ENTERPRISE_SERVER = 0x0000000A;

        [NativeTypeName("#define PRODUCT_STARTER 0x0000000B")]
        public const int PRODUCT_STARTER = 0x0000000B;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE 0x0000000C")]
        public const int PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE 0x0000000D")]
        public const int PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE 0x0000000E")]
        public const int PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_IA64 0x0000000F")]
        public const int PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;

        [NativeTypeName("#define PRODUCT_BUSINESS_N 0x00000010")]
        public const int PRODUCT_BUSINESS_N = 0x00000010;

        [NativeTypeName("#define PRODUCT_WEB_SERVER 0x00000011")]
        public const int PRODUCT_WEB_SERVER = 0x00000011;

        [NativeTypeName("#define PRODUCT_CLUSTER_SERVER 0x00000012")]
        public const int PRODUCT_CLUSTER_SERVER = 0x00000012;

        [NativeTypeName("#define PRODUCT_HOME_SERVER 0x00000013")]
        public const int PRODUCT_HOME_SERVER = 0x00000013;

        [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER 0x00000014")]
        public const int PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER 0x00000015")]
        public const int PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER 0x00000016")]
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;

        [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER 0x00000017")]
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS 0x00000018")]
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM 0x00000019")]
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_N 0x0000001A")]
        public const int PRODUCT_HOME_PREMIUM_N = 0x0000001A;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_N 0x0000001B")]
        public const int PRODUCT_ENTERPRISE_N = 0x0000001B;

        [NativeTypeName("#define PRODUCT_ULTIMATE_N 0x0000001C")]
        public const int PRODUCT_ULTIMATE_N = 0x0000001C;

        [NativeTypeName("#define PRODUCT_WEB_SERVER_CORE 0x0000001D")]
        public const int PRODUCT_WEB_SERVER_CORE = 0x0000001D;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT 0x0000001E")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY 0x0000001F")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;

        [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING 0x00000020")]
        public const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;

        [NativeTypeName("#define PRODUCT_SERVER_FOUNDATION 0x00000021")]
        public const int PRODUCT_SERVER_FOUNDATION = 0x00000021;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_SERVER 0x00000022")]
        public const int PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS_V 0x00000023")]
        public const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_V 0x00000024")]
        public const int PRODUCT_STANDARD_SERVER_V = 0x00000024;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_V 0x00000025")]
        public const int PRODUCT_DATACENTER_SERVER_V = 0x00000025;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_V 0x00000026")]
        public const int PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE_V 0x00000027")]
        public const int PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE_V 0x00000028")]
        public const int PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE_V 0x00000029")]
        public const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;

        [NativeTypeName("#define PRODUCT_HYPERV 0x0000002A")]
        public const int PRODUCT_HYPERV = 0x0000002A;

        [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER_CORE 0x0000002B")]
        public const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER_CORE 0x0000002C")]
        public const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER_CORE 0x0000002D")]
        public const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;

        [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE 0x0000002E")]
        public const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;

        [NativeTypeName("#define PRODUCT_STARTER_N 0x0000002F")]
        public const int PRODUCT_STARTER_N = 0x0000002F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL 0x00000030")]
        public const int PRODUCT_PROFESSIONAL = 0x00000030;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_N 0x00000031")]
        public const int PRODUCT_PROFESSIONAL_N = 0x00000031;

        [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER 0x00000032")]
        public const int PRODUCT_SB_SOLUTION_SERVER = 0x00000032;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS 0x00000033")]
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS 0x00000034")]
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;

        [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE 0x00000035")]
        public const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;

        [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER_EM 0x00000036")]
        public const int PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;

        [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM 0x00000037")]
        public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;

        [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER 0x00000038")]
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;

        [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE 0x00000039")]
        public const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_EMBEDDED 0x0000003A")]
        public const int PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT 0x0000003B")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL 0x0000003C")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC 0x0000003D")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;

        [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC 0x0000003E")]
        public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;

        [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE 0x0000003F")]
        public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;

        [NativeTypeName("#define PRODUCT_CLUSTER_SERVER_V 0x00000040")]
        public const int PRODUCT_CLUSTER_SERVER_V = 0x00000040;

        [NativeTypeName("#define PRODUCT_EMBEDDED 0x00000041")]
        public const int PRODUCT_EMBEDDED = 0x00000041;

        [NativeTypeName("#define PRODUCT_STARTER_E 0x00000042")]
        public const int PRODUCT_STARTER_E = 0x00000042;

        [NativeTypeName("#define PRODUCT_HOME_BASIC_E 0x00000043")]
        public const int PRODUCT_HOME_BASIC_E = 0x00000043;

        [NativeTypeName("#define PRODUCT_HOME_PREMIUM_E 0x00000044")]
        public const int PRODUCT_HOME_PREMIUM_E = 0x00000044;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_E 0x00000045")]
        public const int PRODUCT_PROFESSIONAL_E = 0x00000045;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_E 0x00000046")]
        public const int PRODUCT_ENTERPRISE_E = 0x00000046;

        [NativeTypeName("#define PRODUCT_ULTIMATE_E 0x00000047")]
        public const int PRODUCT_ULTIMATE_E = 0x00000047;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_EVALUATION 0x00000048")]
        public const int PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;

        [NativeTypeName("#define PRODUCT_MULTIPOINT_STANDARD_SERVER 0x0000004C")]
        public const int PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;

        [NativeTypeName("#define PRODUCT_MULTIPOINT_PREMIUM_SERVER 0x0000004D")]
        public const int PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;

        [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER 0x0000004F")]
        public const int PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;

        [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER 0x00000050")]
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_N_EVALUATION 0x00000054")]
        public const int PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;

        [NativeTypeName("#define PRODUCT_EMBEDDED_AUTOMOTIVE 0x00000055")]
        public const int PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A 0x00000056")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;

        [NativeTypeName("#define PRODUCT_THINPC 0x00000057")]
        public const int PRODUCT_THINPC = 0x00000057;

        [NativeTypeName("#define PRODUCT_EMBEDDED_A 0x00000058")]
        public const int PRODUCT_EMBEDDED_A = 0x00000058;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY 0x00000059")]
        public const int PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;

        [NativeTypeName("#define PRODUCT_EMBEDDED_E 0x0000005A")]
        public const int PRODUCT_EMBEDDED_E = 0x0000005A;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E 0x0000005B")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A_E 0x0000005C")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;

        [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER 0x0000005F")]
        public const int PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;

        [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER 0x00000060")]
        public const int PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;

        [NativeTypeName("#define PRODUCT_CORE_ARM 0x00000061")]
        public const int PRODUCT_CORE_ARM = 0x00000061;

        [NativeTypeName("#define PRODUCT_CORE_N 0x00000062")]
        public const int PRODUCT_CORE_N = 0x00000062;

        [NativeTypeName("#define PRODUCT_CORE_COUNTRYSPECIFIC 0x00000063")]
        public const int PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;

        [NativeTypeName("#define PRODUCT_CORE_SINGLELANGUAGE 0x00000064")]
        public const int PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;

        [NativeTypeName("#define PRODUCT_CORE 0x00000065")]
        public const int PRODUCT_CORE = 0x00000065;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_WMC 0x00000067")]
        public const int PRODUCT_PROFESSIONAL_WMC = 0x00000067;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_EVAL 0x00000069")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;

        [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E_EVAL 0x0000006A")]
        public const int PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;

        [NativeTypeName("#define PRODUCT_EMBEDDED_EVAL 0x0000006B")]
        public const int PRODUCT_EMBEDDED_EVAL = 0x0000006B;

        [NativeTypeName("#define PRODUCT_EMBEDDED_E_EVAL 0x0000006C")]
        public const int PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;

        [NativeTypeName("#define PRODUCT_NANO_SERVER 0x0000006D")]
        public const int PRODUCT_NANO_SERVER = 0x0000006D;

        [NativeTypeName("#define PRODUCT_CLOUD_STORAGE_SERVER 0x0000006E")]
        public const int PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED 0x0000006F")]
        public const int PRODUCT_CORE_CONNECTED = 0x0000006F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT 0x00000070")]
        public const int PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_N 0x00000071")]
        public const int PRODUCT_CORE_CONNECTED_N = 0x00000071;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT_N 0x00000072")]
        public const int PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_SINGLELANGUAGE 0x00000073")]
        public const int PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;

        [NativeTypeName("#define PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC 0x00000074")]
        public const int PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;

        [NativeTypeName("#define PRODUCT_CONNECTED_CAR 0x00000075")]
        public const int PRODUCT_CONNECTED_CAR = 0x00000075;

        [NativeTypeName("#define PRODUCT_INDUSTRY_HANDHELD 0x00000076")]
        public const int PRODUCT_INDUSTRY_HANDHELD = 0x00000076;

        [NativeTypeName("#define PRODUCT_PPI_PRO 0x00000077")]
        public const int PRODUCT_PPI_PRO = 0x00000077;

        [NativeTypeName("#define PRODUCT_ARM64_SERVER 0x00000078")]
        public const int PRODUCT_ARM64_SERVER = 0x00000078;

        [NativeTypeName("#define PRODUCT_EDUCATION 0x00000079")]
        public const int PRODUCT_EDUCATION = 0x00000079;

        [NativeTypeName("#define PRODUCT_EDUCATION_N 0x0000007A")]
        public const int PRODUCT_EDUCATION_N = 0x0000007A;

        [NativeTypeName("#define PRODUCT_IOTUAP 0x0000007B")]
        public const int PRODUCT_IOTUAP = 0x0000007B;

        [NativeTypeName("#define PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER 0x0000007C")]
        public const int PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S 0x0000007D")]
        public const int PRODUCT_ENTERPRISE_S = 0x0000007D;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N 0x0000007E")]
        public const int PRODUCT_ENTERPRISE_S_N = 0x0000007E;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_S 0x0000007F")]
        public const int PRODUCT_PROFESSIONAL_S = 0x0000007F;

        [NativeTypeName("#define PRODUCT_PROFESSIONAL_S_N 0x00000080")]
        public const int PRODUCT_PROFESSIONAL_S_N = 0x00000080;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_EVALUATION 0x00000081")]
        public const int PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N_EVALUATION 0x00000082")]
        public const int PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;

        [NativeTypeName("#define PRODUCT_HOLOGRAPHIC 0x00000087")]
        public const int PRODUCT_HOLOGRAPHIC = 0x00000087;

        [NativeTypeName("#define PRODUCT_HOLOGRAPHIC_BUSINESS 0x00000088")]
        public const int PRODUCT_HOLOGRAPHIC_BUSINESS = 0x00000088;

        [NativeTypeName("#define PRODUCT_PRO_SINGLE_LANGUAGE 0x0000008A")]
        public const int PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;

        [NativeTypeName("#define PRODUCT_PRO_CHINA 0x0000008B")]
        public const int PRODUCT_PRO_CHINA = 0x0000008B;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION 0x0000008C")]
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;

        [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION_N 0x0000008D")]
        public const int PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;

        [NativeTypeName("#define PRODUCT_DATACENTER_NANO_SERVER 0x0000008F")]
        public const int PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;

        [NativeTypeName("#define PRODUCT_STANDARD_NANO_SERVER 0x00000090")]
        public const int PRODUCT_STANDARD_NANO_SERVER = 0x00000090;

        [NativeTypeName("#define PRODUCT_DATACENTER_A_SERVER_CORE 0x00000091")]
        public const int PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;

        [NativeTypeName("#define PRODUCT_STANDARD_A_SERVER_CORE 0x00000092")]
        public const int PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;

        [NativeTypeName("#define PRODUCT_DATACENTER_WS_SERVER_CORE 0x00000093")]
        public const int PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;

        [NativeTypeName("#define PRODUCT_STANDARD_WS_SERVER_CORE 0x00000094")]
        public const int PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;

        [NativeTypeName("#define PRODUCT_UTILITY_VM 0x00000095")]
        public const int PRODUCT_UTILITY_VM = 0x00000095;

        [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER_CORE 0x0000009F")]
        public const int PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;

        [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER_CORE 0x000000A0")]
        public const int PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;

        [NativeTypeName("#define PRODUCT_PRO_WORKSTATION 0x000000A1")]
        public const int PRODUCT_PRO_WORKSTATION = 0x000000A1;

        [NativeTypeName("#define PRODUCT_PRO_WORKSTATION_N 0x000000A2")]
        public const int PRODUCT_PRO_WORKSTATION_N = 0x000000A2;

        [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION 0x000000A4")]
        public const int PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;

        [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION_N 0x000000A5")]
        public const int PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;

        [NativeTypeName("#define PRODUCT_AZURE_SERVER_CORE 0x000000A8")]
        public const int PRODUCT_AZURE_SERVER_CORE = 0x000000A8;

        [NativeTypeName("#define PRODUCT_AZURE_NANO_SERVER 0x000000A9")]
        public const int PRODUCT_AZURE_NANO_SERVER = 0x000000A9;

        [NativeTypeName("#define PRODUCT_ENTERPRISEG 0x000000AB")]
        public const int PRODUCT_ENTERPRISEG = 0x000000AB;

        [NativeTypeName("#define PRODUCT_ENTERPRISEGN 0x000000AC")]
        public const int PRODUCT_ENTERPRISEGN = 0x000000AC;

        [NativeTypeName("#define PRODUCT_SERVERRDSH 0x000000AF")]
        public const int PRODUCT_SERVERRDSH = 0x000000AF;

        [NativeTypeName("#define PRODUCT_CLOUD 0x000000B2")]
        public const int PRODUCT_CLOUD = 0x000000B2;

        [NativeTypeName("#define PRODUCT_CLOUDN 0x000000B3")]
        public const int PRODUCT_CLOUDN = 0x000000B3;

        [NativeTypeName("#define PRODUCT_HUBOS 0x000000B4")]
        public const int PRODUCT_HUBOS = 0x000000B4;

        [NativeTypeName("#define PRODUCT_ONECOREUPDATEOS 0x000000B6")]
        public const int PRODUCT_ONECOREUPDATEOS = 0x000000B6;

        [NativeTypeName("#define PRODUCT_CLOUDE 0x000000B7")]
        public const int PRODUCT_CLOUDE = 0x000000B7;

        [NativeTypeName("#define PRODUCT_IOTOS 0x000000B9")]
        public const int PRODUCT_IOTOS = 0x000000B9;

        [NativeTypeName("#define PRODUCT_CLOUDEN 0x000000BA")]
        public const int PRODUCT_CLOUDEN = 0x000000BA;

        [NativeTypeName("#define PRODUCT_IOTEDGEOS 0x000000BB")]
        public const int PRODUCT_IOTEDGEOS = 0x000000BB;

        [NativeTypeName("#define PRODUCT_IOTENTERPRISE 0x000000BC")]
        public const int PRODUCT_IOTENTERPRISE = 0x000000BC;

        [NativeTypeName("#define PRODUCT_LITE 0x000000BD")]
        public const int PRODUCT_LITE = 0x000000BD;

        [NativeTypeName("#define PRODUCT_IOTENTERPRISES 0x000000BF")]
        public const int PRODUCT_IOTENTERPRISES = 0x000000BF;

        [NativeTypeName("#define PRODUCT_XBOX_SYSTEMOS 0x000000C0")]
        public const int PRODUCT_XBOX_SYSTEMOS = 0x000000C0;

        [NativeTypeName("#define PRODUCT_XBOX_NATIVEOS 0x000000C1")]
        public const int PRODUCT_XBOX_NATIVEOS = 0x000000C1;

        [NativeTypeName("#define PRODUCT_XBOX_GAMEOS 0x000000C2")]
        public const int PRODUCT_XBOX_GAMEOS = 0x000000C2;

        [NativeTypeName("#define PRODUCT_XBOX_ERAOS 0x000000C3")]
        public const int PRODUCT_XBOX_ERAOS = 0x000000C3;

        [NativeTypeName("#define PRODUCT_XBOX_DURANGOHOSTOS 0x000000C4")]
        public const int PRODUCT_XBOX_DURANGOHOSTOS = 0x000000C4;

        [NativeTypeName("#define PRODUCT_XBOX_SCARLETTHOSTOS 0x000000C5")]
        public const int PRODUCT_XBOX_SCARLETTHOSTOS = 0x000000C5;

        [NativeTypeName("#define PRODUCT_AZURESTACKHCI_SERVER_CORE 0x00000196")]
        public const int PRODUCT_AZURESTACKHCI_SERVER_CORE = 0x00000196;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_AZURE_EDITION 0x00000197")]
        public const int PRODUCT_DATACENTER_SERVER_AZURE_EDITION = 0x00000197;

        [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION 0x00000198")]
        public const int PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION = 0x00000198;

        [NativeTypeName("#define PRODUCT_UNLICENSED 0xABCDABCD")]
        public const uint PRODUCT_UNLICENSED = 0xABCDABCD;
    }
}
