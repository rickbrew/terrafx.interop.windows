// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct RPC_ENDPOINT_TEMPLATEA
{
    /// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA.ProtSeq"]/*' />
    [NativeTypeName("RPC_CSTR")]
    public byte* ProtSeq;

    /// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA.Endpoint"]/*' />
    [NativeTypeName("RPC_CSTR")]
    public byte* Endpoint;

    /// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA.SecurityDescriptor"]/*' />
    public void* SecurityDescriptor;

    /// <include file='RPC_ENDPOINT_TEMPLATEA.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEA.Backlog"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Backlog;
}
