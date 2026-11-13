// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct RPC_INTERFACE_TEMPLATEW
{
    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.IfSpec"]/*' />
    [NativeTypeName("RPC_IF_HANDLE")]
    public void* IfSpec;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MgrTypeUuid"]/*' />
    [NativeTypeName("UUID *")]
    public Guid* MgrTypeUuid;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MgrEpv"]/*' />
    public void* MgrEpv;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Flags"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Flags;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MaxCalls"]/*' />
    [NativeTypeName("unsigned int")]
    public uint MaxCalls;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.MaxRpcSize"]/*' />
    [NativeTypeName("unsigned int")]
    public uint MaxRpcSize;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.IfCallback"]/*' />
    [NativeTypeName("RPC_IF_CALLBACK_FN *")]
    public delegate* unmanaged<void*, void*, int> IfCallback;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.UuidVector"]/*' />
    public UUID_VECTOR* UuidVector;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.Annotation"]/*' />
    [NativeTypeName("RPC_WSTR")]
    public ushort* Annotation;

    /// <include file='RPC_INTERFACE_TEMPLATEW.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEW.SecurityDescriptor"]/*' />
    public void* SecurityDescriptor;
}
