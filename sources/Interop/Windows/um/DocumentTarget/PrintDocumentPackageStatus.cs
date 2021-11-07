// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct PrintDocumentPackageStatus
    {
        [NativeTypeName("UINT32")]
        public uint JobId;

        [NativeTypeName("INT32")]
        public int CurrentDocument;

        [NativeTypeName("INT32")]
        public int CurrentPage;

        [NativeTypeName("INT32")]
        public int CurrentPageTotal;

        public PrintDocumentPackageCompletion Completion;

        public HRESULT PackageStatus;
    }
}
