// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule"]/*' />
public unsafe partial struct CGlobalModule : CGlobalModule.Interface
{
    public void** lpVtbl;

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalStopListening"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalStopListening(IGlobalStopListeningProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalStopListeningProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[0]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalCacheCleanup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalCacheCleanup()
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[1]))((CGlobalModule*)Unsafe.AsPointer(ref this));
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalCacheOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalCacheOperation(ICacheProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, ICacheProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[2]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalHealthCheck"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalHealthCheck()
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[3]))((CGlobalModule*)Unsafe.AsPointer(ref this));
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalConfigurationChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalConfigurationChange(IGlobalConfigurationChangeProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalConfigurationChangeProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[4]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalFileChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalFileChange(IGlobalFileChangeProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalFileChangeProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[5]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalPreBeginRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalPreBeginRequest(IPreBeginRequestProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IPreBeginRequestProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[6]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalApplicationStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationStart([NativeTypeName("IHttpApplicationStartProvider *")] IHttpApplicationProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IHttpApplicationProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[7]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalApplicationResolveModules"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationResolveModules(IHttpApplicationResolveModulesProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IHttpApplicationResolveModulesProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[8]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalApplicationStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationStop([NativeTypeName("IHttpApplicationStopProvider *")] IHttpApplicationProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IHttpApplicationProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[9]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalRSCAQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalRSCAQuery(IGlobalRSCAQueryProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalRSCAQueryProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[10]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalTraceEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalTraceEvent(IGlobalTraceEventProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalTraceEventProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[11]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalCustomNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalCustomNotification(ICustomNotificationProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, ICustomNotificationProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[12]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.Terminate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void Terminate()
    {
        ((delegate* unmanaged[MemberFunction]<CGlobalModule*, void>)(lpVtbl[13]))((CGlobalModule*)Unsafe.AsPointer(ref this));
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalThreadCleanup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalThreadCleanup(IGlobalThreadCleanupProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalThreadCleanupProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[14]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnGlobalApplicationPreload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationPreload(IGlobalApplicationPreloadProvider* pProvider)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalApplicationPreloadProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[15]))((CGlobalModule*)Unsafe.AsPointer(ref this), pProvider);
    }

    /// <include file='CGlobalModule.xml' path='doc/member[@name="CGlobalModule.OnSuspendProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public GLOBAL_NOTIFICATION_STATUS OnSuspendProcess(IGlobalSuspendProcessCallback** pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<CGlobalModule*, IGlobalSuspendProcessCallback**, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[16]))((CGlobalModule*)Unsafe.AsPointer(ref this), pCallback);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalStopListening(IGlobalStopListeningProvider* pProvider);

        [VtblIndex(1)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalCacheCleanup();

        [VtblIndex(2)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalCacheOperation(ICacheProvider* pProvider);

        [VtblIndex(3)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalHealthCheck();

        [VtblIndex(4)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalConfigurationChange(IGlobalConfigurationChangeProvider* pProvider);

        [VtblIndex(5)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalFileChange(IGlobalFileChangeProvider* pProvider);

        [VtblIndex(6)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalPreBeginRequest(IPreBeginRequestProvider* pProvider);

        [VtblIndex(7)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationStart([NativeTypeName("IHttpApplicationStartProvider *")] IHttpApplicationProvider* pProvider);

        [VtblIndex(8)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationResolveModules(IHttpApplicationResolveModulesProvider* pProvider);

        [VtblIndex(9)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationStop([NativeTypeName("IHttpApplicationStopProvider *")] IHttpApplicationProvider* pProvider);

        [VtblIndex(10)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalRSCAQuery(IGlobalRSCAQueryProvider* pProvider);

        [VtblIndex(11)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalTraceEvent(IGlobalTraceEventProvider* pProvider);

        [VtblIndex(12)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalCustomNotification(ICustomNotificationProvider* pProvider);

        [VtblIndex(13)]
        void Terminate();

        [VtblIndex(14)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalThreadCleanup(IGlobalThreadCleanupProvider* pProvider);

        [VtblIndex(15)]
        GLOBAL_NOTIFICATION_STATUS OnGlobalApplicationPreload(IGlobalApplicationPreloadProvider* pProvider);

        [VtblIndex(16)]
        GLOBAL_NOTIFICATION_STATUS OnSuspendProcess(IGlobalSuspendProcessCallback** pCallback);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalStopListeningProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalStopListeningProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalStopListening;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GLOBAL_NOTIFICATION_STATUS> OnGlobalCacheCleanup;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (ICacheProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICacheProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalCacheOperation;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GLOBAL_NOTIFICATION_STATUS> OnGlobalHealthCheck;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalConfigurationChangeProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalConfigurationChangeProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalConfigurationChange;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalFileChangeProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalFileChangeProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalFileChange;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IPreBeginRequestProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPreBeginRequestProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalPreBeginRequest;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IHttpApplicationStartProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplicationProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalApplicationStart;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IHttpApplicationResolveModulesProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplicationResolveModulesProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalApplicationResolveModules;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IHttpApplicationStopProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplicationProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalApplicationStop;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalRSCAQueryProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalRSCAQueryProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalRSCAQuery;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalTraceEventProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalTraceEventProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalTraceEvent;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (ICustomNotificationProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICustomNotificationProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalCustomNotification;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> Terminate;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalThreadCleanupProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalThreadCleanupProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalThreadCleanup;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalApplicationPreloadProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalApplicationPreloadProvider*, GLOBAL_NOTIFICATION_STATUS> OnGlobalApplicationPreload;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (IGlobalSuspendProcessCallback **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGlobalSuspendProcessCallback**, GLOBAL_NOTIFICATION_STATUS> OnSuspendProcess;
    }
}
