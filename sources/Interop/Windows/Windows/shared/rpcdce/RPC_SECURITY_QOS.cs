// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_SECURITY_QOS.xml' path='doc/member[@name="RPC_SECURITY_QOS"]/*' />
public partial struct RPC_SECURITY_QOS
{
    /// <include file='RPC_SECURITY_QOS.xml' path='doc/member[@name="RPC_SECURITY_QOS.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_SECURITY_QOS.xml' path='doc/member[@name="RPC_SECURITY_QOS.Capabilities"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Capabilities;

    /// <include file='RPC_SECURITY_QOS.xml' path='doc/member[@name="RPC_SECURITY_QOS.IdentityTracking"]/*' />
    [NativeTypeName("unsigned long")]
    public uint IdentityTracking;

    /// <include file='RPC_SECURITY_QOS.xml' path='doc/member[@name="RPC_SECURITY_QOS.ImpersonationType"]/*' />
    [NativeTypeName("unsigned long")]
    public uint ImpersonationType;
}
