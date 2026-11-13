// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class RPC
{
    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_BINDING_INFINITE_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_BINDING_INFINITE_TIMEOUT 10")]
    public const int RPC_C_BINDING_INFINITE_TIMEOUT = 10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_BINDING_MIN_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_BINDING_MIN_TIMEOUT 0")]
    public const int RPC_C_BINDING_MIN_TIMEOUT = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_BINDING_DEFAULT_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_BINDING_DEFAULT_TIMEOUT 5")]
    public const int RPC_C_BINDING_DEFAULT_TIMEOUT = 5;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_BINDING_MAX_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_BINDING_MAX_TIMEOUT 9")]
    public const int RPC_C_BINDING_MAX_TIMEOUT = 9;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_CANCEL_INFINITE_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_CANCEL_INFINITE_TIMEOUT -1")]
    public const int RPC_C_CANCEL_INFINITE_TIMEOUT = -1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_LISTEN_MAX_CALLS_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_LISTEN_MAX_CALLS_DEFAULT 1234")]
    public const int RPC_C_LISTEN_MAX_CALLS_DEFAULT = 1234;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTSEQ_MAX_REQS_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_PROTSEQ_MAX_REQS_DEFAULT 10")]
    public const int RPC_C_PROTSEQ_MAX_REQS_DEFAULT = 10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_BIND_TO_ALL_NICS"]/*' />
    [NativeTypeName("#define RPC_C_BIND_TO_ALL_NICS 1")]
    public const int RPC_C_BIND_TO_ALL_NICS = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_USE_INTERNET_PORT"]/*' />
    [NativeTypeName("#define RPC_C_USE_INTERNET_PORT 0x1")]
    public const int RPC_C_USE_INTERNET_PORT = 0x1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_USE_INTRANET_PORT"]/*' />
    [NativeTypeName("#define RPC_C_USE_INTRANET_PORT 0x2")]
    public const int RPC_C_USE_INTRANET_PORT = 0x2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_DONT_FAIL"]/*' />
    [NativeTypeName("#define RPC_C_DONT_FAIL 0x4")]
    public const int RPC_C_DONT_FAIL = 0x4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_RPCHTTP_USE_LOAD_BALANCE"]/*' />
    [NativeTypeName("#define RPC_C_RPCHTTP_USE_LOAD_BALANCE 0x8")]
    public const int RPC_C_RPCHTTP_USE_LOAD_BALANCE = 0x8;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_TRY_ENFORCE_MAX_CALLS"]/*' />
    [NativeTypeName("#define RPC_C_TRY_ENFORCE_MAX_CALLS 0x10")]
    public const int RPC_C_TRY_ENFORCE_MAX_CALLS = 0x10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_BINDING_NONCAUSAL"]/*' />
    [NativeTypeName("#define RPC_C_OPT_BINDING_NONCAUSAL 9")]
    public const int RPC_C_OPT_BINDING_NONCAUSAL = 9;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_SECURITY_CALLBACK"]/*' />
    [NativeTypeName("#define RPC_C_OPT_SECURITY_CALLBACK 10")]
    public const int RPC_C_OPT_SECURITY_CALLBACK = 10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_UNIQUE_BINDING"]/*' />
    [NativeTypeName("#define RPC_C_OPT_UNIQUE_BINDING 11")]
    public const int RPC_C_OPT_UNIQUE_BINDING = 11;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_TRANS_SEND_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define RPC_C_OPT_TRANS_SEND_BUFFER_SIZE 5")]
    public const int RPC_C_OPT_TRANS_SEND_BUFFER_SIZE = 5;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_CALL_TIMEOUT"]/*' />
    [NativeTypeName("#define RPC_C_OPT_CALL_TIMEOUT 12")]
    public const int RPC_C_OPT_CALL_TIMEOUT = 12;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_DONT_LINGER"]/*' />
    [NativeTypeName("#define RPC_C_OPT_DONT_LINGER 13")]
    public const int RPC_C_OPT_DONT_LINGER = 13;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_TRUST_PEER"]/*' />
    [NativeTypeName("#define RPC_C_OPT_TRUST_PEER 14")]
    public const int RPC_C_OPT_TRUST_PEER = 14;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_ASYNC_BLOCK"]/*' />
    [NativeTypeName("#define RPC_C_OPT_ASYNC_BLOCK 15")]
    public const int RPC_C_OPT_ASYNC_BLOCK = 15;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_OPTIMIZE_TIME"]/*' />
    [NativeTypeName("#define RPC_C_OPT_OPTIMIZE_TIME 16")]
    public const int RPC_C_OPT_OPTIMIZE_TIME = 16;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_OPT_MAX_OPTIONS"]/*' />
    [NativeTypeName("#define RPC_C_OPT_MAX_OPTIONS 17")]
    public const int RPC_C_OPT_MAX_OPTIONS = 17;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_FULL_CERT_CHAIN"]/*' />
    [NativeTypeName("#define RPC_C_FULL_CERT_CHAIN 0x0001")]
    public const int RPC_C_FULL_CERT_CHAIN = 0x0001;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_STATS_CALLS_IN"]/*' />
    [NativeTypeName("#define RPC_C_STATS_CALLS_IN 0")]
    public const int RPC_C_STATS_CALLS_IN = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_STATS_CALLS_OUT"]/*' />
    [NativeTypeName("#define RPC_C_STATS_CALLS_OUT 1")]
    public const int RPC_C_STATS_CALLS_OUT = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_STATS_PKTS_IN"]/*' />
    [NativeTypeName("#define RPC_C_STATS_PKTS_IN 2")]
    public const int RPC_C_STATS_PKTS_IN = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_STATS_PKTS_OUT"]/*' />
    [NativeTypeName("#define RPC_C_STATS_PKTS_OUT 3")]
    public const int RPC_C_STATS_PKTS_OUT = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_DEFAULT 0")]
    public const int RPC_C_AUTHN_LEVEL_DEFAULT = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_NONE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_NONE 1")]
    public const int RPC_C_AUTHN_LEVEL_NONE = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_CONNECT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_CONNECT 2")]
    public const int RPC_C_AUTHN_LEVEL_CONNECT = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_CALL"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_CALL 3")]
    public const int RPC_C_AUTHN_LEVEL_CALL = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_PKT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT 4")]
    public const int RPC_C_AUTHN_LEVEL_PKT = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_PKT_INTEGRITY"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT_INTEGRITY 5")]
    public const int RPC_C_AUTHN_LEVEL_PKT_INTEGRITY = 5;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LEVEL_PKT_PRIVACY"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LEVEL_PKT_PRIVACY 6")]
    public const int RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_IMP_LEVEL_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_IMP_LEVEL_DEFAULT 0")]
    public const int RPC_C_IMP_LEVEL_DEFAULT = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_IMP_LEVEL_ANONYMOUS"]/*' />
    [NativeTypeName("#define RPC_C_IMP_LEVEL_ANONYMOUS 1")]
    public const int RPC_C_IMP_LEVEL_ANONYMOUS = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_IMP_LEVEL_IDENTIFY"]/*' />
    [NativeTypeName("#define RPC_C_IMP_LEVEL_IDENTIFY 2")]
    public const int RPC_C_IMP_LEVEL_IDENTIFY = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_IMP_LEVEL_IMPERSONATE"]/*' />
    [NativeTypeName("#define RPC_C_IMP_LEVEL_IMPERSONATE 3")]
    public const int RPC_C_IMP_LEVEL_IMPERSONATE = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_IMP_LEVEL_DELEGATE"]/*' />
    [NativeTypeName("#define RPC_C_IMP_LEVEL_DELEGATE 4")]
    public const int RPC_C_IMP_LEVEL_DELEGATE = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_IDENTITY_STATIC"]/*' />
    [NativeTypeName("#define RPC_C_QOS_IDENTITY_STATIC 0")]
    public const int RPC_C_QOS_IDENTITY_STATIC = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_IDENTITY_DYNAMIC"]/*' />
    [NativeTypeName("#define RPC_C_QOS_IDENTITY_DYNAMIC 1")]
    public const int RPC_C_QOS_IDENTITY_DYNAMIC = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_DEFAULT 0x0")]
    public const int RPC_C_QOS_CAPABILITIES_DEFAULT = 0x0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH 0x1")]
    public const int RPC_C_QOS_CAPABILITIES_MUTUAL_AUTH = 0x1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC 0x2")]
    public const int RPC_C_QOS_CAPABILITIES_MAKE_FULLSIC = 0x2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY 0x4")]
    public const int RPC_C_QOS_CAPABILITIES_ANY_AUTHORITY = 0x4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE 0x8")]
    public const int RPC_C_QOS_CAPABILITIES_IGNORE_DELEGATE_FAILURE = 0x8;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT 0x10")]
    public const int RPC_C_QOS_CAPABILITIES_LOCAL_MA_HINT = 0x10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_QOS_CAPABILITIES_SCHANNEL_FULL_AUTH_IDENTITY"]/*' />
    [NativeTypeName("#define RPC_C_QOS_CAPABILITIES_SCHANNEL_FULL_AUTH_IDENTITY 0x20")]
    public const int RPC_C_QOS_CAPABILITIES_SCHANNEL_FULL_AUTH_IDENTITY = 0x20;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_DEFAULT (RPC_C_AUTHN_LEVEL_DEFAULT)")]
    public const int RPC_C_PROTECT_LEVEL_DEFAULT = (0);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_NONE"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_NONE (RPC_C_AUTHN_LEVEL_NONE)")]
    public const int RPC_C_PROTECT_LEVEL_NONE = (1);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_CONNECT"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_CONNECT (RPC_C_AUTHN_LEVEL_CONNECT)")]
    public const int RPC_C_PROTECT_LEVEL_CONNECT = (2);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_CALL"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_CALL (RPC_C_AUTHN_LEVEL_CALL)")]
    public const int RPC_C_PROTECT_LEVEL_CALL = (3);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_PKT"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT (RPC_C_AUTHN_LEVEL_PKT)")]
    public const int RPC_C_PROTECT_LEVEL_PKT = (4);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_PKT_INTEGRITY"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT_INTEGRITY (RPC_C_AUTHN_LEVEL_PKT_INTEGRITY)")]
    public const int RPC_C_PROTECT_LEVEL_PKT_INTEGRITY = (5);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PROTECT_LEVEL_PKT_PRIVACY"]/*' />
    [NativeTypeName("#define RPC_C_PROTECT_LEVEL_PKT_PRIVACY (RPC_C_AUTHN_LEVEL_PKT_PRIVACY)")]
    public const int RPC_C_PROTECT_LEVEL_PKT_PRIVACY = (6);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_NONE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_NONE 0")]
    public const int RPC_C_AUTHN_NONE = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DCE_PRIVATE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DCE_PRIVATE 1")]
    public const int RPC_C_AUTHN_DCE_PRIVATE = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DCE_PUBLIC"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DCE_PUBLIC 2")]
    public const int RPC_C_AUTHN_DCE_PUBLIC = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DEC_PUBLIC"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DEC_PUBLIC 4")]
    public const int RPC_C_AUTHN_DEC_PUBLIC = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_GSS_NEGOTIATE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_GSS_NEGOTIATE 9")]
    public const int RPC_C_AUTHN_GSS_NEGOTIATE = 9;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_WINNT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_WINNT 10")]
    public const int RPC_C_AUTHN_WINNT = 10;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_GSS_SCHANNEL"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_GSS_SCHANNEL 14")]
    public const int RPC_C_AUTHN_GSS_SCHANNEL = 14;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_GSS_KERBEROS"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_GSS_KERBEROS 16")]
    public const int RPC_C_AUTHN_GSS_KERBEROS = 16;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DPA"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DPA 17")]
    public const int RPC_C_AUTHN_DPA = 17;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_MSN"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_MSN 18")]
    public const int RPC_C_AUTHN_MSN = 18;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DIGEST"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DIGEST 21")]
    public const int RPC_C_AUTHN_DIGEST = 21;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_KERNEL"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_KERNEL 20")]
    public const int RPC_C_AUTHN_KERNEL = 20;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_NEGO_EXTENDER"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_NEGO_EXTENDER 30")]
    public const int RPC_C_AUTHN_NEGO_EXTENDER = 30;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_PKU2U"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_PKU2U 31")]
    public const int RPC_C_AUTHN_PKU2U = 31;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LIVE_SSP"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LIVE_SSP 32")]
    public const int RPC_C_AUTHN_LIVE_SSP = 32;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_LIVEXP_SSP"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_LIVEXP_SSP 35")]
    public const int RPC_C_AUTHN_LIVEXP_SSP = 35;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_CLOUD_AP"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_CLOUD_AP 36")]
    public const int RPC_C_AUTHN_CLOUD_AP = 36;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_MSONLINE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_MSONLINE 82")]
    public const int RPC_C_AUTHN_MSONLINE = 82;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_MQ"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_MQ 100")]
    public const int RPC_C_AUTHN_MQ = 100;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_DEFAULT 0xFFFFFFFFL")]
    public const uint RPC_C_AUTHN_DEFAULT = 0xFFFFFFFF;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_NO_CREDENTIALS"]/*' />
    [NativeTypeName("#define RPC_C_NO_CREDENTIALS ((RPC_AUTH_IDENTITY_HANDLE) MAXUINT_PTR)")]
    public static void* RPC_C_NO_CREDENTIALS => ((void*)(unchecked((nuint)(~((nuint)(0))))));

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION 1L")]
    public const int RPC_C_SECURITY_QOS_VERSION = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION_1"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_1 1L")]
    public const int RPC_C_SECURITY_QOS_VERSION_1 = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION_2"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_2 2L")]
    public const int RPC_C_SECURITY_QOS_VERSION_2 = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHN_INFO_TYPE_HTTP"]/*' />
    [NativeTypeName("#define RPC_C_AUTHN_INFO_TYPE_HTTP 1")]
    public const int RPC_C_AUTHN_INFO_TYPE_HTTP = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_TARGET_SERVER"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_TARGET_SERVER 1")]
    public const int RPC_C_HTTP_AUTHN_TARGET_SERVER = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_TARGET_PROXY"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_TARGET_PROXY 2")]
    public const int RPC_C_HTTP_AUTHN_TARGET_PROXY = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_BASIC"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_BASIC 0x00000001")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_BASIC = 0x00000001;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_NTLM"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_NTLM 0x00000002")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_NTLM = 0x00000002;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_PASSPORT"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_PASSPORT 0x00000004")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_PASSPORT = 0x00000004;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_DIGEST"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_DIGEST 0x00000008")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_DIGEST = 0x00000008;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE 0x00000010")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_NEGOTIATE = 0x00000010;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_AUTHN_SCHEME_CERT"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_AUTHN_SCHEME_CERT 0x00010000")]
    public const int RPC_C_HTTP_AUTHN_SCHEME_CERT = 0x00010000;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_FLAG_USE_SSL"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_FLAG_USE_SSL 1")]
    public const int RPC_C_HTTP_FLAG_USE_SSL = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME 2")]
    public const int RPC_C_HTTP_FLAG_USE_FIRST_AUTH_SCHEME = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID 8")]
    public const int RPC_C_HTTP_FLAG_IGNORE_CERT_CN_INVALID = 8;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_HTTP_FLAG_ENABLE_CERT_REVOCATION_CHECK"]/*' />
    [NativeTypeName("#define RPC_C_HTTP_FLAG_ENABLE_CERT_REVOCATION_CHECK 16")]
    public const int RPC_C_HTTP_FLAG_ENABLE_CERT_REVOCATION_CHECK = 16;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION_3"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_3 3L")]
    public const int RPC_C_SECURITY_QOS_VERSION_3 = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION_4"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_4 4L")]
    public const int RPC_C_SECURITY_QOS_VERSION_4 = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_SECURITY_QOS_VERSION_5"]/*' />
    [NativeTypeName("#define RPC_C_SECURITY_QOS_VERSION_5 5L")]
    public const int RPC_C_SECURITY_QOS_VERSION_5 = 5;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_PROTSEQ_TCP"]/*' />
    [NativeTypeName("#define RPC_PROTSEQ_TCP (0x1)")]
    public const int RPC_PROTSEQ_TCP = (0x1);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_PROTSEQ_NMP"]/*' />
    [NativeTypeName("#define RPC_PROTSEQ_NMP (0x2)")]
    public const int RPC_PROTSEQ_NMP = (0x2);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_PROTSEQ_LRPC"]/*' />
    [NativeTypeName("#define RPC_PROTSEQ_LRPC (0x3)")]
    public const int RPC_PROTSEQ_LRPC = (0x3);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_PROTSEQ_HTTP"]/*' />
    [NativeTypeName("#define RPC_PROTSEQ_HTTP (0x4)")]
    public const int RPC_PROTSEQ_HTTP = (0x4);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_BHT_OBJECT_UUID_VALID"]/*' />
    [NativeTypeName("#define RPC_BHT_OBJECT_UUID_VALID (0x1)")]
    public const int RPC_BHT_OBJECT_UUID_VALID = (0x1);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_BHO_NONCAUSAL"]/*' />
    [NativeTypeName("#define RPC_BHO_NONCAUSAL (0x1)")]
    public const int RPC_BHO_NONCAUSAL = (0x1);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_BHO_DONTLINGER"]/*' />
    [NativeTypeName("#define RPC_BHO_DONTLINGER (0x2)")]
    public const int RPC_BHO_DONTLINGER = (0x2);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_BHO_EXCLUSIVE_AND_GUARANTEED"]/*' />
    [NativeTypeName("#define RPC_BHO_EXCLUSIVE_AND_GUARANTEED (0x4)")]
    public const int RPC_BHO_EXCLUSIVE_AND_GUARANTEED = (0x4);

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHZ_NONE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHZ_NONE 0")]
    public const int RPC_C_AUTHZ_NONE = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHZ_NAME"]/*' />
    [NativeTypeName("#define RPC_C_AUTHZ_NAME 1")]
    public const int RPC_C_AUTHZ_NAME = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHZ_DCE"]/*' />
    [NativeTypeName("#define RPC_C_AUTHZ_DCE 2")]
    public const int RPC_C_AUTHZ_DCE = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_AUTHZ_DEFAULT"]/*' />
    [NativeTypeName("#define RPC_C_AUTHZ_DEFAULT 0xffffffff")]
    public const uint RPC_C_AUTHZ_DEFAULT = 0xffffffff;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_EP_ALL_ELTS"]/*' />
    [NativeTypeName("#define RPC_C_EP_ALL_ELTS 0")]
    public const int RPC_C_EP_ALL_ELTS = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_EP_MATCH_BY_IF"]/*' />
    [NativeTypeName("#define RPC_C_EP_MATCH_BY_IF 1")]
    public const int RPC_C_EP_MATCH_BY_IF = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_EP_MATCH_BY_OBJ"]/*' />
    [NativeTypeName("#define RPC_C_EP_MATCH_BY_OBJ 2")]
    public const int RPC_C_EP_MATCH_BY_OBJ = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_EP_MATCH_BY_BOTH"]/*' />
    [NativeTypeName("#define RPC_C_EP_MATCH_BY_BOTH 3")]
    public const int RPC_C_EP_MATCH_BY_BOTH = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_VERS_ALL"]/*' />
    [NativeTypeName("#define RPC_C_VERS_ALL 1")]
    public const int RPC_C_VERS_ALL = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_VERS_COMPATIBLE"]/*' />
    [NativeTypeName("#define RPC_C_VERS_COMPATIBLE 2")]
    public const int RPC_C_VERS_COMPATIBLE = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_VERS_EXACT"]/*' />
    [NativeTypeName("#define RPC_C_VERS_EXACT 3")]
    public const int RPC_C_VERS_EXACT = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_VERS_MAJOR_ONLY"]/*' />
    [NativeTypeName("#define RPC_C_VERS_MAJOR_ONLY 4")]
    public const int RPC_C_VERS_MAJOR_ONLY = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_VERS_UPTO"]/*' />
    [NativeTypeName("#define RPC_C_VERS_UPTO 5")]
    public const int RPC_C_VERS_UPTO = 5;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_MGMT_INQ_IF_IDS"]/*' />
    [NativeTypeName("#define RPC_C_MGMT_INQ_IF_IDS 0")]
    public const int RPC_C_MGMT_INQ_IF_IDS = 0;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_MGMT_INQ_PRINC_NAME"]/*' />
    [NativeTypeName("#define RPC_C_MGMT_INQ_PRINC_NAME 1")]
    public const int RPC_C_MGMT_INQ_PRINC_NAME = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_MGMT_INQ_STATS"]/*' />
    [NativeTypeName("#define RPC_C_MGMT_INQ_STATS 2")]
    public const int RPC_C_MGMT_INQ_STATS = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_MGMT_IS_SERVER_LISTEN"]/*' />
    [NativeTypeName("#define RPC_C_MGMT_IS_SERVER_LISTEN 3")]
    public const int RPC_C_MGMT_IS_SERVER_LISTEN = 3;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_MGMT_STOP_SERVER_LISTEN"]/*' />
    [NativeTypeName("#define RPC_C_MGMT_STOP_SERVER_LISTEN 4")]
    public const int RPC_C_MGMT_STOP_SERVER_LISTEN = 4;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PARM_MAX_PACKET_LENGTH"]/*' />
    [NativeTypeName("#define RPC_C_PARM_MAX_PACKET_LENGTH 1")]
    public const int RPC_C_PARM_MAX_PACKET_LENGTH = 1;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_C_PARM_BUFFER_LENGTH"]/*' />
    [NativeTypeName("#define RPC_C_PARM_BUFFER_LENGTH 2")]
    public const int RPC_C_PARM_BUFFER_LENGTH = 2;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_AUTOLISTEN"]/*' />
    [NativeTypeName("#define RPC_IF_AUTOLISTEN 0x0001")]
    public const int RPC_IF_AUTOLISTEN = 0x0001;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_OLE"]/*' />
    [NativeTypeName("#define RPC_IF_OLE 0x0002")]
    public const int RPC_IF_OLE = 0x0002;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_ALLOW_UNKNOWN_AUTHORITY"]/*' />
    [NativeTypeName("#define RPC_IF_ALLOW_UNKNOWN_AUTHORITY 0x0004")]
    public const int RPC_IF_ALLOW_UNKNOWN_AUTHORITY = 0x0004;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_ALLOW_SECURE_ONLY"]/*' />
    [NativeTypeName("#define RPC_IF_ALLOW_SECURE_ONLY 0x0008")]
    public const int RPC_IF_ALLOW_SECURE_ONLY = 0x0008;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH"]/*' />
    [NativeTypeName("#define RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH 0x0010")]
    public const int RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH = 0x0010;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_ALLOW_LOCAL_ONLY"]/*' />
    [NativeTypeName("#define RPC_IF_ALLOW_LOCAL_ONLY 0x0020")]
    public const int RPC_IF_ALLOW_LOCAL_ONLY = 0x0020;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_SEC_NO_CACHE"]/*' />
    [NativeTypeName("#define RPC_IF_SEC_NO_CACHE 0x0040")]
    public const int RPC_IF_SEC_NO_CACHE = 0x0040;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_SEC_CACHE_PER_PROC"]/*' />
    [NativeTypeName("#define RPC_IF_SEC_CACHE_PER_PROC 0x0080")]
    public const int RPC_IF_SEC_CACHE_PER_PROC = 0x0080;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_IF_ASYNC_CALLBACK"]/*' />
    [NativeTypeName("#define RPC_IF_ASYNC_CALLBACK 0x0100")]
    public const int RPC_IF_ASYNC_CALLBACK = 0x0100;

    /// <include file='RPC.xml' path='doc/member[@name="RPC.RPC_FW_IF_FLAG_DCOM"]/*' />
    [NativeTypeName("#define RPC_FW_IF_FLAG_DCOM 0x0001")]
    public const int RPC_FW_IF_FLAG_DCOM = 0x0001;
}
