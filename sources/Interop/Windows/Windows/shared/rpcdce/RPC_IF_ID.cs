// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_IF_ID.xml' path='doc/member[@name="RPC_IF_ID"]/*' />
public partial struct RPC_IF_ID
{
    /// <include file='RPC_IF_ID.xml' path='doc/member[@name="RPC_IF_ID.Uuid"]/*' />
    [NativeTypeName("UUID")]
    public Guid Uuid;

    /// <include file='RPC_IF_ID.xml' path='doc/member[@name="RPC_IF_ID.VersMajor"]/*' />
    [NativeTypeName("unsigned short")]
    public ushort VersMajor;

    /// <include file='RPC_IF_ID.xml' path='doc/member[@name="RPC_IF_ID.VersMinor"]/*' />
    [NativeTypeName("unsigned short")]
    public ushort VersMinor;
}
