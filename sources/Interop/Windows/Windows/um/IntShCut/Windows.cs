// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT TranslateURLA([NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PSTR *")] sbyte** ppszTranslatedURL);

        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT TranslateURLW([NativeTypeName("PCWSTR")] ushort* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("__unaligned PWSTR *")] ushort** ppszTranslatedURL);

        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT URLAssociationDialogA(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("PSTR")] sbyte* pszAppBuf, uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT URLAssociationDialogW(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] ushort* pcszFile, [NativeTypeName("PCWSTR")] ushort* pcszURL, [NativeTypeName("PWSTR")] ushort* pszAppBuf, uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT MIMEAssociationDialogA(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszMIMEContentType, [NativeTypeName("PSTR")] sbyte* pszAppBuf, uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        public static extern HRESULT MIMEAssociationDialogW(HWND hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] ushort* pcszFile, [NativeTypeName("PCWSTR")] ushort* pcszMIMEContentType, [NativeTypeName("PWSTR")] ushort* pszAppBuf, uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        public static extern BOOL InetIsOffline([NativeTypeName("DWORD")] uint dwFlags);

        [NativeTypeName("#define IS_E_EXEC_FAILED MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x2002)")]
        public const int IS_E_EXEC_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x2002))));

        [NativeTypeName("#define URL_E_INVALID_SYNTAX MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1001)")]
        public const int URL_E_INVALID_SYNTAX = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1001))));

        [NativeTypeName("#define URL_E_UNREGISTERED_PROTOCOL MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1002)")]
        public const int URL_E_UNREGISTERED_PROTOCOL = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1002))));

        [NativeTypeName("#define TranslateURL TranslateURLW")]
        public static delegate*<ushort*, uint, ushort**, HRESULT> TranslateURL => &TranslateURLW;

        [NativeTypeName("#define URLAssociationDialog URLAssociationDialogW")]
        public static delegate*<HWND, uint, ushort*, ushort*, ushort*, uint, HRESULT> URLAssociationDialog => &URLAssociationDialogW;

        [NativeTypeName("#define MIMEAssociationDialog MIMEAssociationDialogW")]
        public static delegate*<HWND, uint, ushort*, ushort*, ushort*, uint, HRESULT> MIMEAssociationDialog => &MIMEAssociationDialogW;
    }
}
