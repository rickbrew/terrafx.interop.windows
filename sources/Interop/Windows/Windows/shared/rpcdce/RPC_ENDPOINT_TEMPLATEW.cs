// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct RPC_ENDPOINT_TEMPLATEW
{
    /// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW.ProtSeq"]/*' />
    [NativeTypeName("RPC_WSTR")]
    public ushort* ProtSeq;

    /// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW.Endpoint"]/*' />
    [NativeTypeName("RPC_WSTR")]
    public ushort* Endpoint;

    /// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW.SecurityDescriptor"]/*' />
    public void* SecurityDescriptor;

    /// <include file='RPC_ENDPOINT_TEMPLATEW.xml' path='doc/member[@name="RPC_ENDPOINT_TEMPLATEW.Backlog"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Backlog;
}
