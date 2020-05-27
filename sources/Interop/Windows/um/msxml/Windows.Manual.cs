// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid CLSID_DOMDocument = new Guid(0x2933BF90, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid CLSID_DOMFreeThreadedDocument = new Guid(0x2933BF91, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid CLSID_XMLDSOControl = new Guid(0x550DDA30, 0x0541, 0x11D2, 0x9C, 0xA9, 0x00, 0x60, 0xB0, 0xEC, 0x3D, 0x39);

        public static readonly Guid CLSID_XMLDocument = new Guid(0xCFC399AF, 0xD876, 0x11D0, 0x9C, 0x10, 0x00, 0xC0, 0x4F, 0xC9, 0x9C, 0x8E);

        public static readonly Guid CLSID_XMLHTTPRequest = new Guid(0xED8C108E, 0x4349, 0x11D2, 0x91, 0xA4, 0x00, 0xC0, 0x4F, 0x79, 0x69, 0xE8);

        public static readonly Guid DIID_XMLDOMDocumentEvents = new Guid(0x3EFAA427, 0x272F, 0x11D2, 0x83, 0x6F, 0x00, 0x00, 0xF8, 0x7A, 0x77, 0x82);

        public static readonly Guid IID_IXMLAttribute = new Guid(0xD4D4A0FC, 0x3B73, 0x11D1, 0xB2, 0xB4, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0x96);

        public static readonly Guid IID_IXMLDOMAttribute = new Guid(0x2933BF85, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMCDATASection = new Guid(0x2933BF8A, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMCharacterData = new Guid(0x2933BF84, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMComment = new Guid(0x2933BF88, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMDocument = new Guid(0x2933BF81, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMDocumentFragment = new Guid(0x3EFAA413, 0x272F, 0x11D2, 0x83, 0x6F, 0x00, 0x00, 0xF8, 0x7A, 0x77, 0x82);

        public static readonly Guid IID_IXMLDOMDocumentType = new Guid(0x2933BF8B, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMElement = new Guid(0x2933BF86, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMEntity = new Guid(0x2933BF8D, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMEntityReference = new Guid(0x2933BF8E, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMImplementation = new Guid(0x2933BF8F, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMNamedNodeMap = new Guid(0x2933BF83, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMNode = new Guid(0x2933BF80, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMNodeList = new Guid(0x2933BF82, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMNotation = new Guid(0x2933BF8C, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMParseError = new Guid(0x3EFAA426, 0x272F, 0x11D2, 0x83, 0x6F, 0x00, 0x00, 0xF8, 0x7A, 0x77, 0x82);

        public static readonly Guid IID_IXMLDOMProcessingInstruction = new Guid(0x2933BF89, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDOMText = new Guid(0x2933BF87, 0x7B36, 0x11D2, 0xB2, 0x0E, 0x00, 0xC0, 0x4F, 0x98, 0x3E, 0x60);

        public static readonly Guid IID_IXMLDSOControl = new Guid(0x310AFA62, 0x0575, 0x11D2, 0x9C, 0xA9, 0x00, 0x60, 0xB0, 0xEC, 0x3D, 0x39);

        public static readonly Guid IID_IXMLDocument = new Guid(0xF52E2B61, 0x18A1, 0x11D1, 0xB1, 0x05, 0x00, 0x80, 0x5F, 0x49, 0x91, 0x6B);

        public static readonly Guid IID_IXMLDocument2 = new Guid(0x2B8DE2FE, 0x8D2D, 0x11D1, 0xB2, 0xFC, 0x00, 0xC0, 0x4F, 0xD9, 0x15, 0xA9);

        public static readonly Guid IID_IXMLElement = new Guid(0x3F7F31AC, 0xE15F, 0x11D0, 0x9C, 0x25, 0x00, 0xC0, 0x4F, 0xC9, 0x9C, 0x8E);

        public static readonly Guid IID_IXMLElement2 = new Guid(0x2B8DE2FF, 0x8D2D, 0x11D1, 0xB2, 0xFC, 0x00, 0xC0, 0x4F, 0xD9, 0x15, 0xA9);

        public static readonly Guid IID_IXMLElementCollection = new Guid(0x65725580, 0x9B5D, 0x11D0, 0x9B, 0xFE, 0x00, 0xC0, 0x4F, 0xC9, 0x9C, 0x8E);

        public static readonly Guid IID_IXMLError = new Guid(0x948C5AD3, 0xC58D, 0x11D0, 0x9C, 0x0B, 0x00, 0xC0, 0x4F, 0xC9, 0x9C, 0x8E);

        public static readonly Guid IID_IXMLHttpRequest = new Guid(0xED8C108D, 0x4349, 0x11D2, 0x91, 0xA4, 0x00, 0xC0, 0x4F, 0x79, 0x69, 0xE8);

        public static readonly Guid IID_IXTLRuntime = new Guid(0x3EFAA425, 0x272F, 0x11D2, 0x83, 0x6F, 0x00, 0x00, 0xF8, 0x7A, 0x77, 0x82);

        public static readonly Guid LIBID_MSXML = new Guid(0xD63E0CE2, 0xA0A2, 0x11D0, 0x9C, 0x02, 0x00, 0xC0, 0x4F, 0xC9, 0x9C, 0x8E);
    }
}
