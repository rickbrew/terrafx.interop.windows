// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SSL_SET_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_SET_EX"]/*' />
public partial struct HTTP_SERVICE_CONFIG_SSL_SET_EX
{
    /// <include file='HTTP_SERVICE_CONFIG_SSL_SET_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_SET_EX.KeyDesc"]/*' />
    public HTTP_SERVICE_CONFIG_SSL_KEY_EX KeyDesc;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_SET_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_SET_EX.ParamDesc"]/*' />
    public HTTP_SERVICE_CONFIG_SSL_PARAM_EX ParamDesc;
}
