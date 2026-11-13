// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/rpcdce.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE"]/*' />
public enum RPC_HTTP_REDIRECTOR_STAGE
{
    /// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE.RPCHTTP_RS_REDIRECT"]/*' />
    RPCHTTP_RS_REDIRECT = 1,

    /// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE.RPCHTTP_RS_ACCESS_1"]/*' />
    RPCHTTP_RS_ACCESS_1,

    /// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE.RPCHTTP_RS_SESSION"]/*' />
    RPCHTTP_RS_SESSION,

    /// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE.RPCHTTP_RS_ACCESS_2"]/*' />
    RPCHTTP_RS_ACCESS_2,

    /// <include file='RPC_HTTP_REDIRECTOR_STAGE.xml' path='doc/member[@name="RPC_HTTP_REDIRECTOR_STAGE.RPCHTTP_RS_INTERFACE"]/*' />
    RPCHTTP_RS_INTERFACE,
}
