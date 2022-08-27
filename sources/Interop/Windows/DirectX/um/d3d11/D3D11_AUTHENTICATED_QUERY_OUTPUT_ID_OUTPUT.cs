// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.Output"]/*' />
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.DeviceHandle"]/*' />
    public HANDLE DeviceHandle;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.CryptoSessionHandle"]/*' />
    public HANDLE CryptoSessionHandle;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.OutputIDIndex"]/*' />
    public uint OutputIDIndex;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT.OutputID"]/*' />
    [NativeTypeName("UINT64")]
    public ulong OutputID;
}
