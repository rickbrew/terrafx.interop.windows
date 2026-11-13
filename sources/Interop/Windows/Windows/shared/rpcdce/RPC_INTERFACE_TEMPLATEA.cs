// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct RPC_INTERFACE_TEMPLATEA
{
    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.Version"]/*' />
    [NativeTypeName("unsigned long")]
    public uint Version;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.IfSpec"]/*' />
    [NativeTypeName("RPC_IF_HANDLE")]
    public void* IfSpec;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.MgrTypeUuid"]/*' />
    [NativeTypeName("UUID *")]
    public Guid* MgrTypeUuid;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.MgrEpv"]/*' />
    public void* MgrEpv;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.Flags"]/*' />
    [NativeTypeName("unsigned int")]
    public uint Flags;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.MaxCalls"]/*' />
    [NativeTypeName("unsigned int")]
    public uint MaxCalls;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.MaxRpcSize"]/*' />
    [NativeTypeName("unsigned int")]
    public uint MaxRpcSize;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.IfCallback"]/*' />
    [NativeTypeName("RPC_IF_CALLBACK_FN *")]
    public delegate* unmanaged<void*, void*, int> IfCallback;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.UuidVector"]/*' />
    public UUID_VECTOR* UuidVector;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.Annotation"]/*' />
    [NativeTypeName("RPC_CSTR")]
    public byte* Annotation;

    /// <include file='RPC_INTERFACE_TEMPLATEA.xml' path='doc/member[@name="RPC_INTERFACE_TEMPLATEA.SecurityDescriptor"]/*' />
    public void* SecurityDescriptor;
}
