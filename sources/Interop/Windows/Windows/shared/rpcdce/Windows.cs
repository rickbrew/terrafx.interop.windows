// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingCopy"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingCopy([NativeTypeName("RPC_BINDING_HANDLE")] void* SourceBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** DestinationBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingFree"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingFree([NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetOption"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetOption([NativeTypeName("RPC_BINDING_HANDLE")] void* hBinding, [NativeTypeName("unsigned long")] uint option, [NativeTypeName("ULONG_PTR")] nuint optionValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqOption"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqOption([NativeTypeName("RPC_BINDING_HANDLE")] void* hBinding, [NativeTypeName("unsigned long")] uint option, [NativeTypeName("ULONG_PTR *")] nuint* pOptionValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingFromStringBindingA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingFromStringBindingA([NativeTypeName("RPC_CSTR")] byte* StringBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingFromStringBindingW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingFromStringBindingW([NativeTypeName("RPC_WSTR")] ushort* StringBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcSsGetContextBinding"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcSsGetContextBinding(void* ContextHandle, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqMaxCalls"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqMaxCalls([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int *")] uint* MaxCalls);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqObject"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqObject([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingReset"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingReset([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetObject"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetObject([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqDefaultProtectLevel"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqDefaultProtectLevel([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthnLevel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingToStringBindingA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingToStringBindingA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** StringBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingToStringBindingW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingToStringBindingW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** StringBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingVectorFree"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingVectorFree(RPC_BINDING_VECTOR** BindingVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingComposeA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringBindingComposeA([NativeTypeName("RPC_CSTR")] byte* ObjUuid, [NativeTypeName("RPC_CSTR")] byte* ProtSeq, [NativeTypeName("RPC_CSTR")] byte* NetworkAddr, [NativeTypeName("RPC_CSTR")] byte* Endpoint, [NativeTypeName("RPC_CSTR")] byte* Options, [NativeTypeName("RPC_CSTR *")] byte** StringBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingComposeW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringBindingComposeW([NativeTypeName("RPC_WSTR")] ushort* ObjUuid, [NativeTypeName("RPC_WSTR")] ushort* ProtSeq, [NativeTypeName("RPC_WSTR")] ushort* NetworkAddr, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, [NativeTypeName("RPC_WSTR")] ushort* Options, [NativeTypeName("RPC_WSTR *")] ushort** StringBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingParseA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringBindingParseA([NativeTypeName("RPC_CSTR")] byte* StringBinding, [NativeTypeName("RPC_CSTR *")] byte** ObjUuid, [NativeTypeName("RPC_CSTR *")] byte** Protseq, [NativeTypeName("RPC_CSTR *")] byte** NetworkAddr, [NativeTypeName("RPC_CSTR *")] byte** Endpoint, [NativeTypeName("RPC_CSTR *")] byte** NetworkOptions);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingParseW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringBindingParseW([NativeTypeName("RPC_WSTR")] ushort* StringBinding, [NativeTypeName("RPC_WSTR *")] ushort** ObjUuid, [NativeTypeName("RPC_WSTR *")] ushort** Protseq, [NativeTypeName("RPC_WSTR *")] ushort** NetworkAddr, [NativeTypeName("RPC_WSTR *")] ushort** Endpoint, [NativeTypeName("RPC_WSTR *")] ushort** NetworkOptions);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringFreeA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringFreeA([NativeTypeName("RPC_CSTR *")] byte** String);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringFreeW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcStringFreeW([NativeTypeName("RPC_WSTR *")] ushort** String);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcIfInqId"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcIfInqId([NativeTypeName("RPC_IF_HANDLE")] void* RpcIfHandle, RPC_IF_ID* RpcIfId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkIsProtseqValidA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNetworkIsProtseqValidA([NativeTypeName("RPC_CSTR")] byte* Protseq);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkIsProtseqValidW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNetworkIsProtseqValidW([NativeTypeName("RPC_WSTR")] ushort* Protseq);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqComTimeout"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqComTimeout([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int *")] uint* Timeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtSetComTimeout"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtSetComTimeout([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned int")] uint Timeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtSetCancelTimeout"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtSetCancelTimeout([NativeTypeName("long")] int Timeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkInqProtseqsA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNetworkInqProtseqsA(RPC_PROTSEQ_VECTORA** ProtseqVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkInqProtseqsW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNetworkInqProtseqsW(RPC_PROTSEQ_VECTORW** ProtseqVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcObjectInqType"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcObjectInqType([NativeTypeName("UUID *")] Guid* ObjUuid, [NativeTypeName("UUID *")] Guid* TypeUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcObjectSetInqFn"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcObjectSetInqFn([NativeTypeName("RPC_OBJECT_INQ_FN *")] delegate* unmanaged<Guid*, Guid*, int*, void> InquiryFn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcObjectSetType"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcObjectSetType([NativeTypeName("UUID *")] Guid* ObjUuid, [NativeTypeName("UUID *")] Guid* TypeUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcProtseqVectorFreeA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcProtseqVectorFreeA(RPC_PROTSEQ_VECTORA** ProtseqVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcProtseqVectorFreeW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcProtseqVectorFreeW(RPC_PROTSEQ_VECTORW** ProtseqVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqBindings"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqBindings(RPC_BINDING_VECTOR** BindingVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqBindingsEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqBindingsEx(void* SecurityDescriptor, RPC_BINDING_VECTOR** BindingVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqIf"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void** MgrEpv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerListen"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerListen([NativeTypeName("unsigned int")] uint MinimumCallThreads, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint DontWait);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterIf"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerRegisterIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterIfEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerRegisterIfEx([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallback);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterIf2"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerRegisterIf2([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint MaxRpcSize, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallbackFn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterIf3"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerRegisterIf3([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, void* MgrEpv, [NativeTypeName("unsigned int")] uint Flags, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("unsigned int")] uint MaxRpcSize, [NativeTypeName("RPC_IF_CALLBACK_FN *")] delegate* unmanaged<void*, void*, int> IfCallback, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUnregisterIf"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUnregisterIf([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, [NativeTypeName("unsigned int")] uint WaitForCallsToComplete);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUnregisterIfEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUnregisterIfEx([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, [NativeTypeName("UUID *")] Guid* MgrTypeUuid, int RundownContextHandles);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseAllProtseqs"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseAllProtseqs([NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseAllProtseqsEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseAllProtseqsEx([NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseAllProtseqsIf"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseAllProtseqsIf([NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseAllProtseqsIfEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseAllProtseqsIfEx([NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEpA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqEpA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_CSTR")] byte* Endpoint, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEpExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqEpExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_CSTR")] byte* Endpoint, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEpW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqEpW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEpExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqEpExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_WSTR")] ushort* Endpoint, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIfA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqIfA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIfExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqIfExA([NativeTypeName("RPC_CSTR")] byte* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIfW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqIfW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIfExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerUseProtseqIfExW([NativeTypeName("RPC_WSTR")] ushort* Protseq, [NativeTypeName("unsigned int")] uint MaxCalls, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, void* SecurityDescriptor, [NativeTypeName("PRPC_POLICY")] RPC_POLICY* Policy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerYield"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern void RpcServerYield();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtStatsVectorFree"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtStatsVectorFree(RPC_STATS_VECTOR** StatsVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqStats"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqStats([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, RPC_STATS_VECTOR** Statistics);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtIsServerListening"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtIsServerListening([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtStopServerListening"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtStopServerListening([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtWaitServerListen"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtWaitServerListen();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtSetServerStackSize"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtSetServerStackSize([NativeTypeName("unsigned long")] uint ThreadStackSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcSsDontSerializeContext"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern void RpcSsDontSerializeContext();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEnableIdleCleanup"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEnableIdleCleanup();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqIfIds"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqIfIds([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, RPC_IF_ID_VECTOR** IfIdVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcIfIdVectorFree"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcIfIdVectorFree(RPC_IF_ID_VECTOR** IfIdVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqServerPrincNameA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqServerPrincNameA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqServerPrincNameW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtInqServerPrincNameW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqDefaultPrincNameA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqDefaultPrincNameA([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_CSTR *")] byte** PrincName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqDefaultPrincNameW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqDefaultPrincNameW([NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_WSTR *")] ushort** PrincName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpResolveBinding"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpResolveBinding([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_IF_HANDLE")] void* IfSpec);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNsBindingInqEntryNameA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNsBindingInqEntryNameA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_CSTR *")] byte** EntryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNsBindingInqEntryNameW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcNsBindingInqEntryNameW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("unsigned long")] uint EntryNameSyntax, [NativeTypeName("RPC_WSTR *")] ushort** EntryName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingCreateA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingCreateA(RPC_BINDING_HANDLE_TEMPLATE_V1_A* Template, RPC_BINDING_HANDLE_SECURITY_V1_A* Security, RPC_BINDING_HANDLE_OPTIONS_V1* Options, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingCreateW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingCreateW(RPC_BINDING_HANDLE_TEMPLATE_V1_W* Template, RPC_BINDING_HANDLE_SECURITY_V1_W* Security, RPC_BINDING_HANDLE_OPTIONS_V1* Options, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqBindingHandle"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerInqBindingHandle([NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcImpersonateClient"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcImpersonateClient([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcImpersonateClient2"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcImpersonateClient2([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcRevertToSelfEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcRevertToSelfEx([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcRevertToSelf"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcRevertToSelf();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcImpersonateClientContainer"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcImpersonateClientContainer([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcRevertContainerImpersonation"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcRevertContainerImpersonation();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClientA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthClientA([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClientW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthClientW([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClientExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthClientExA([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClientExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthClientExW([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** Privs, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfoA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthInfoA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfoW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthInfoW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfoA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetAuthInfoA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfoExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetAuthInfoExA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc, RPC_SECURITY_QOS* SecurityQos);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfoW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetAuthInfoW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfoExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingSetAuthInfoExW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnLevel, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* AuthIdentity, [NativeTypeName("unsigned long")] uint AuthzSvc, RPC_SECURITY_QOS* SecurityQOS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfoExA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthInfoExA([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_CSTR *")] byte** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint RpcQosVersion, RPC_SECURITY_QOS* SecurityQOS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfoExW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingInqAuthInfoExW([NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("RPC_WSTR *")] ushort** ServerPrincName, [NativeTypeName("unsigned long *")] uint* AuthnLevel, [NativeTypeName("unsigned long *")] uint* AuthnSvc, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** AuthIdentity, [NativeTypeName("unsigned long *")] uint* AuthzSvc, [NativeTypeName("unsigned long")] uint RpcQosVersion, RPC_SECURITY_QOS* SecurityQOS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerCompleteSecurityCallback"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerCompleteSecurityCallback([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle, [NativeTypeName("RPC_STATUS")] int Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterAuthInfoA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerRegisterAuthInfoA([NativeTypeName("RPC_CSTR")] byte* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_KEY_RETRIEVAL_FN")] delegate* unmanaged<void*, ushort*, uint, void**, int*, void> GetKeyFn, void* Arg);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterAuthInfoW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerRegisterAuthInfoW([NativeTypeName("RPC_WSTR")] ushort* ServerPrincName, [NativeTypeName("unsigned long")] uint AuthnSvc, [NativeTypeName("RPC_AUTH_KEY_RETRIEVAL_FN")] delegate* unmanaged<void*, ushort*, uint, void**, int*, void> GetKeyFn, void* Arg);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingServerFromClient"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcBindingServerFromClient([NativeTypeName("RPC_BINDING_HANDLE")] void* ClientBinding, [NativeTypeName("RPC_BINDING_HANDLE *")] void** ServerBinding);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcRaiseException"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern void RpcRaiseException([NativeTypeName("RPC_STATUS")] int exception);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcTestCancel"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcTestCancel();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerTestCancel"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcServerTestCancel([NativeTypeName("RPC_BINDING_HANDLE")] void* BindingHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcCancelThread"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcCancelThread(void* Thread);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcCancelThreadEx"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcCancelThreadEx(void* Thread, [NativeTypeName("long")] int Timeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidCreate"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidCreate([NativeTypeName("UUID *")] Guid* Uuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidCreateSequential"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidCreateSequential([NativeTypeName("UUID *")] Guid* Uuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidToStringA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidToStringA([NativeTypeName("const UUID *")] Guid* Uuid, [NativeTypeName("RPC_CSTR *")] byte** StringUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidFromStringA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidFromStringA([NativeTypeName("RPC_CSTR")] byte* StringUuid, [NativeTypeName("UUID *")] Guid* Uuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidToStringW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidToStringW([NativeTypeName("const UUID *")] Guid* Uuid, [NativeTypeName("RPC_WSTR *")] ushort** StringUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidFromStringW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidFromStringW([NativeTypeName("RPC_WSTR")] ushort* StringUuid, [NativeTypeName("UUID *")] Guid* Uuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidCompare"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern int UuidCompare([NativeTypeName("UUID *")] Guid* Uuid1, [NativeTypeName("UUID *")] Guid* Uuid2, [NativeTypeName("RPC_STATUS *")] int* Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidCreateNil"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int UuidCreateNil([NativeTypeName("UUID *")] Guid* NilUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidEqual"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern int UuidEqual([NativeTypeName("UUID *")] Guid* Uuid1, [NativeTypeName("UUID *")] Guid* Uuid2, [NativeTypeName("RPC_STATUS *")] int* Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidHash"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("unsigned short")]
    public static extern ushort UuidHash([NativeTypeName("UUID *")] Guid* Uuid, [NativeTypeName("RPC_STATUS *")] int* Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidIsNil"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern int UuidIsNil([NativeTypeName("UUID *")] Guid* Uuid, [NativeTypeName("RPC_STATUS *")] int* Status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegisterNoReplaceA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpRegisterNoReplaceA([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_CSTR")] byte* Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegisterNoReplaceW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpRegisterNoReplaceW([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_WSTR")] ushort* Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegisterA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpRegisterA([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_CSTR")] byte* Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegisterW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpRegisterW([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector, [NativeTypeName("RPC_WSTR")] ushort* Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpUnregister"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcEpUnregister([NativeTypeName("RPC_IF_HANDLE")] void* IfSpec, RPC_BINDING_VECTOR* BindingVector, UUID_VECTOR* UuidVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DceErrorInqTextA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int DceErrorInqTextA([NativeTypeName("RPC_STATUS")] int RpcStatus, [NativeTypeName("RPC_CSTR")] byte* ErrorText);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DceErrorInqTextW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int DceErrorInqTextW([NativeTypeName("RPC_STATUS")] int RpcStatus, [NativeTypeName("RPC_WSTR")] ushort* ErrorText);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpEltInqBegin"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEpEltInqBegin([NativeTypeName("RPC_BINDING_HANDLE")] void* EpBinding, [NativeTypeName("unsigned long")] uint InquiryType, RPC_IF_ID* IfId, [NativeTypeName("unsigned long")] uint VersOption, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_EP_INQ_HANDLE *")] void*** InquiryContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpEltInqDone"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEpEltInqDone([NativeTypeName("RPC_EP_INQ_HANDLE *")] void*** InquiryContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpEltInqNextA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEpEltInqNextA([NativeTypeName("RPC_EP_INQ_HANDLE")] void** InquiryContext, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_CSTR *")] byte** Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpEltInqNextW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEpEltInqNextW([NativeTypeName("RPC_EP_INQ_HANDLE")] void** InquiryContext, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE *")] void** Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid, [NativeTypeName("RPC_WSTR *")] ushort** Annotation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpUnregister"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtEpUnregister([NativeTypeName("RPC_BINDING_HANDLE")] void* EpBinding, RPC_IF_ID* IfId, [NativeTypeName("RPC_BINDING_HANDLE")] void* Binding, [NativeTypeName("UUID *")] Guid* ObjectUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtSetAuthorizationFn"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    public static extern int RpcMgmtSetAuthorizationFn([NativeTypeName("RPC_MGMT_AUTHORIZATION_FN")] delegate* unmanaged<void*, uint, int*, int> AuthorizationFn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcExceptionFilter"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    public static extern int RpcExceptionFilter([NativeTypeName("unsigned long")] uint ExceptionCode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupCreateW"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupCreateW(RPC_INTERFACE_TEMPLATEW* Interfaces, [NativeTypeName("unsigned long")] uint NumIfs, RPC_ENDPOINT_TEMPLATEW* Endpoints, [NativeTypeName("unsigned long")] uint NumEndpoints, [NativeTypeName("unsigned long")] uint IdlePeriod, [NativeTypeName("RPC_INTERFACE_GROUP_IDLE_CALLBACK_FN")] delegate* unmanaged<void*, void*, uint, void> IdleCallbackFn, void* IdleCallbackContext, [NativeTypeName("PRPC_INTERFACE_GROUP")] void** IfGroup);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupCreateA"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupCreateA(RPC_INTERFACE_TEMPLATEA* Interfaces, [NativeTypeName("unsigned long")] uint NumIfs, RPC_ENDPOINT_TEMPLATEA* Endpoints, [NativeTypeName("unsigned long")] uint NumEndpoints, [NativeTypeName("unsigned long")] uint IdlePeriod, [NativeTypeName("RPC_INTERFACE_GROUP_IDLE_CALLBACK_FN")] delegate* unmanaged<void*, void*, uint, void> IdleCallbackFn, void* IdleCallbackContext, [NativeTypeName("PRPC_INTERFACE_GROUP")] void** IfGroup);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupClose"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupClose([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupActivate"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupActivate([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupDeactivate"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupDeactivate([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup, [NativeTypeName("unsigned long")] uint ForceDeactivation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupInqBindings"]/*' />
    [DllImport("rpcrt4", ExactSpelling = true)]
    [return: NativeTypeName("RPC_STATUS")]
    [SupportedOSPlatform("windows6.2")]
    public static extern int RpcServerInterfaceGroupInqBindings([NativeTypeName("RPC_INTERFACE_GROUP")] void* IfGroup, RPC_BINDING_VECTOR** BindingVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingFromStringBinding"]/*' />
    [NativeTypeName("#define RpcBindingFromStringBinding RpcBindingFromStringBindingW")]
    public static delegate*<ushort*, void**, int> RpcBindingFromStringBinding => &RpcBindingFromStringBindingW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingToStringBinding"]/*' />
    [NativeTypeName("#define RpcBindingToStringBinding RpcBindingToStringBindingW")]
    public static delegate*<void*, ushort**, int> RpcBindingToStringBinding => &RpcBindingToStringBindingW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingCompose"]/*' />
    [NativeTypeName("#define RpcStringBindingCompose RpcStringBindingComposeW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort*, ushort*, ushort**, int> RpcStringBindingCompose => &RpcStringBindingComposeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringBindingParse"]/*' />
    [NativeTypeName("#define RpcStringBindingParse RpcStringBindingParseW")]
    public static delegate*<ushort*, ushort**, ushort**, ushort**, ushort**, ushort**, int> RpcStringBindingParse => &RpcStringBindingParseW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcStringFree"]/*' />
    [NativeTypeName("#define RpcStringFree RpcStringFreeW")]
    public static delegate*<ushort**, int> RpcStringFree => &RpcStringFreeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkIsProtseqValid"]/*' />
    [NativeTypeName("#define RpcNetworkIsProtseqValid RpcNetworkIsProtseqValidW")]
    public static delegate*<ushort*, int> RpcNetworkIsProtseqValid => &RpcNetworkIsProtseqValidW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNetworkInqProtseqs"]/*' />
    [NativeTypeName("#define RpcNetworkInqProtseqs RpcNetworkInqProtseqsW")]
    public static delegate*<RPC_PROTSEQ_VECTORW**, int> RpcNetworkInqProtseqs => &RpcNetworkInqProtseqsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcProtseqVectorFree"]/*' />
    [NativeTypeName("#define RpcProtseqVectorFree RpcProtseqVectorFreeW")]
    public static delegate*<RPC_PROTSEQ_VECTORW**, int> RpcProtseqVectorFree => &RpcProtseqVectorFreeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseq"]/*' />
    [NativeTypeName("#define RpcServerUseProtseq RpcServerUseProtseqW")]
    public static delegate*<ushort*, uint, void*, int> RpcServerUseProtseq => &RpcServerUseProtseqW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEx"]/*' />
    [NativeTypeName("#define RpcServerUseProtseqEx RpcServerUseProtseqExW")]
    public static delegate*<ushort*, uint, void*, RPC_POLICY*, int> RpcServerUseProtseqEx => &RpcServerUseProtseqExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEp"]/*' />
    [NativeTypeName("#define RpcServerUseProtseqEp RpcServerUseProtseqEpW")]
    public static delegate*<ushort*, uint, ushort*, void*, int> RpcServerUseProtseqEp => &RpcServerUseProtseqEpW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqEpEx"]/*' />
    [NativeTypeName("#define RpcServerUseProtseqEpEx RpcServerUseProtseqEpExW")]
    public static delegate*<ushort*, uint, ushort*, void*, RPC_POLICY*, int> RpcServerUseProtseqEpEx => &RpcServerUseProtseqEpExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIf"]/*' />
    [NativeTypeName("#define RpcServerUseProtseqIf RpcServerUseProtseqIfW")]
    public static delegate*<ushort*, uint, void*, void*, int> RpcServerUseProtseqIf => &RpcServerUseProtseqIfW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerUseProtseqIfEx"]/*' />
    [NativeTypeName("#define RpcServerUseProtseqIfEx RpcServerUseProtseqIfExW")]
    public static delegate*<ushort*, uint, void*, void*, RPC_POLICY*, int> RpcServerUseProtseqIfEx => &RpcServerUseProtseqIfExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtInqServerPrincName"]/*' />
    [NativeTypeName("#define RpcMgmtInqServerPrincName RpcMgmtInqServerPrincNameW")]
    public static delegate*<void*, uint, ushort**, int> RpcMgmtInqServerPrincName => &RpcMgmtInqServerPrincNameW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInqDefaultPrincName"]/*' />
    [NativeTypeName("#define RpcServerInqDefaultPrincName RpcServerInqDefaultPrincNameW")]
    public static delegate*<uint, ushort**, int> RpcServerInqDefaultPrincName => &RpcServerInqDefaultPrincNameW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcNsBindingInqEntryName"]/*' />
    [NativeTypeName("#define RpcNsBindingInqEntryName RpcNsBindingInqEntryNameW")]
    public static delegate*<void*, uint, ushort**, int> RpcNsBindingInqEntryName => &RpcNsBindingInqEntryNameW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingCreate"]/*' />
    [NativeTypeName("#define RpcBindingCreate RpcBindingCreateW")]
    public static delegate*<RPC_BINDING_HANDLE_TEMPLATE_V1_W*, RPC_BINDING_HANDLE_SECURITY_V1_W*, RPC_BINDING_HANDLE_OPTIONS_V1*, void**, int> RpcBindingCreate => &RpcBindingCreateW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClient"]/*' />
    [NativeTypeName("#define RpcBindingInqAuthClient RpcBindingInqAuthClientW")]
    public static delegate*<void*, void**, ushort**, uint*, uint*, uint*, int> RpcBindingInqAuthClient => &RpcBindingInqAuthClientW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthClientEx"]/*' />
    [NativeTypeName("#define RpcBindingInqAuthClientEx RpcBindingInqAuthClientExW")]
    public static delegate*<void*, void**, ushort**, uint*, uint*, uint*, uint, int> RpcBindingInqAuthClientEx => &RpcBindingInqAuthClientExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfo"]/*' />
    [NativeTypeName("#define RpcBindingInqAuthInfo RpcBindingInqAuthInfoW")]
    public static delegate*<void*, ushort**, uint*, uint*, void**, uint*, int> RpcBindingInqAuthInfo => &RpcBindingInqAuthInfoW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfo"]/*' />
    [NativeTypeName("#define RpcBindingSetAuthInfo RpcBindingSetAuthInfoW")]
    public static delegate*<void*, ushort*, uint, uint, void*, uint, int> RpcBindingSetAuthInfo => &RpcBindingSetAuthInfoW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerRegisterAuthInfo"]/*' />
    [NativeTypeName("#define RpcServerRegisterAuthInfo RpcServerRegisterAuthInfoW")]
    public static delegate*<ushort*, uint, delegate* unmanaged<void*, ushort*, uint, void**, int*, void>, void*, int> RpcServerRegisterAuthInfo => &RpcServerRegisterAuthInfoW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingInqAuthInfoEx"]/*' />
    [NativeTypeName("#define RpcBindingInqAuthInfoEx RpcBindingInqAuthInfoExW")]
    public static delegate*<void*, ushort**, uint*, uint*, void**, uint*, uint, RPC_SECURITY_QOS*, int> RpcBindingInqAuthInfoEx => &RpcBindingInqAuthInfoExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcBindingSetAuthInfoEx"]/*' />
    [NativeTypeName("#define RpcBindingSetAuthInfoEx RpcBindingSetAuthInfoExW")]
    public static delegate*<void*, ushort*, uint, uint, void*, uint, RPC_SECURITY_QOS*, int> RpcBindingSetAuthInfoEx => &RpcBindingSetAuthInfoExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidFromString"]/*' />
    [NativeTypeName("#define UuidFromString UuidFromStringW")]
    public static delegate*<ushort*, Guid*, int> UuidFromString => &UuidFromStringW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UuidToString"]/*' />
    [NativeTypeName("#define UuidToString UuidToStringW")]
    public static delegate*<Guid*, ushort**, int> UuidToString => &UuidToStringW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegisterNoReplace"]/*' />
    [NativeTypeName("#define RpcEpRegisterNoReplace RpcEpRegisterNoReplaceW")]
    public static delegate*<void*, RPC_BINDING_VECTOR*, UUID_VECTOR*, ushort*, int> RpcEpRegisterNoReplace => &RpcEpRegisterNoReplaceW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcEpRegister"]/*' />
    [NativeTypeName("#define RpcEpRegister RpcEpRegisterW")]
    public static delegate*<void*, RPC_BINDING_VECTOR*, UUID_VECTOR*, ushort*, int> RpcEpRegister => &RpcEpRegisterW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DCE_C_ERROR_STRING_LEN"]/*' />
    [NativeTypeName("#define DCE_C_ERROR_STRING_LEN 256")]
    public const int DCE_C_ERROR_STRING_LEN = 256;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DceErrorInqText"]/*' />
    [NativeTypeName("#define DceErrorInqText DceErrorInqTextW")]
    public static delegate*<int, ushort*, int> DceErrorInqText => &DceErrorInqTextW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcMgmtEpEltInqNext"]/*' />
    [NativeTypeName("#define RpcMgmtEpEltInqNext RpcMgmtEpEltInqNextW")]
    public static delegate*<void**, RPC_IF_ID*, void**, Guid*, ushort**, int> RpcMgmtEpEltInqNext => &RpcMgmtEpEltInqNextW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RpcServerInterfaceGroupCreate"]/*' />
    [NativeTypeName("#define RpcServerInterfaceGroupCreate RpcServerInterfaceGroupCreateW")]
    [SupportedOSPlatform("windows6.2")]
    public static delegate*<RPC_INTERFACE_TEMPLATEW*, uint, RPC_ENDPOINT_TEMPLATEW*, uint, uint, delegate* unmanaged<void*, void*, uint, void>, void*, void**, int> RpcServerInterfaceGroupCreate => &RpcServerInterfaceGroupCreateW;
}
