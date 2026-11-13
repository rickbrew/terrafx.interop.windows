// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_POLICY.xml' path='doc/member[@name="RPC_POLICY"]/*' />
public partial struct RPC_POLICY
{
    /// <include file='RPC_POLICY.xml' path='doc/member[@name="RPC_POLICY.Length"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Length;

    /// <include file='RPC_POLICY.xml' path='doc/member[@name="RPC_POLICY.EndpointFlags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint EndpointFlags;

    /// <include file='RPC_POLICY.xml' path='doc/member[@name="RPC_POLICY.NICFlags"]/*' />
    [NativeTypeName("unsigned long")]
    public uint NICFlags;
}
