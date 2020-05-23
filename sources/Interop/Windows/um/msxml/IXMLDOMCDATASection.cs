// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF8A-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMCDATASection
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLDOMCDATASection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLDOMCDATASection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLDOMCDATASection* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLDOMCDATASection* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLDOMCDATASection* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLDOMCDATASection* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLDOMCDATASection* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeName(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeValue(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT *")] VARIANT* value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_nodeValue(IXMLDOMCDATASection* pThis, VARIANT value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeType(IXMLDOMCDATASection* pThis, [NativeTypeName("DOMNodeType *")] DOMNodeType* type);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parentNode(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_childNodes(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_firstChild(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_lastChild(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_previousSibling(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nextSibling(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_attributes(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _insertBefore(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _replaceChild(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeChild(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _appendChild(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _hasChildNodes(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT_BOOL *")] short* hasChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_ownerDocument(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _cloneNode(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeTypeString(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** nodeType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_text(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** text);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_text(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* text);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_specified(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isSpecified);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_definition(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeTypedValue(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT *")] VARIANT* typedValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_nodeTypedValue(IXMLDOMCDATASection* pThis, VARIANT typedValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_dataType(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT *")] VARIANT* dataTypeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_dataType(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* dataTypeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_xml(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** xmlString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _transformNode(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _selectNodes(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _selectSingleNode(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parsed(IXMLDOMCDATASection* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isParsed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_namespaceURI(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** namespaceURI);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_prefix(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** prefixString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_baseName(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** nameString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _transformNodeToObject(IXMLDOMCDATASection* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_data(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR *")] ushort** data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_data(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_length(IXMLDOMCDATASection* pThis, [NativeTypeName("long *")] int* dataLength);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _substringData(IXMLDOMCDATASection* pThis, [NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] ushort** data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _appendData(IXMLDOMCDATASection* pThis, [NativeTypeName("BSTR")] ushort* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _insertData(IXMLDOMCDATASection* pThis, [NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _deleteData(IXMLDOMCDATASection* pThis, [NativeTypeName("long")] int offset, [NativeTypeName("long")] int count);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _replaceData(IXMLDOMCDATASection* pThis, [NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] ushort* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _splitText(IXMLDOMCDATASection* pThis, [NativeTypeName("long")] int offset, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** rightHandTextNode);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeName>(lpVtbl->get_nodeName)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeValue>(lpVtbl->get_nodeValue)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_nodeValue>(lpVtbl->put_nodeValue)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeType>(lpVtbl->get_nodeType)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parentNode>(lpVtbl->get_parentNode)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_childNodes>(lpVtbl->get_childNodes)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_firstChild>(lpVtbl->get_firstChild)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_lastChild>(lpVtbl->get_lastChild)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_previousSibling>(lpVtbl->get_previousSibling)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nextSibling>(lpVtbl->get_nextSibling)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_attributes>(lpVtbl->get_attributes)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_insertBefore>(lpVtbl->insertBefore)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_replaceChild>(lpVtbl->replaceChild)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeChild>(lpVtbl->removeChild)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_appendChild>(lpVtbl->appendChild)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_hasChildNodes>(lpVtbl->hasChildNodes)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_ownerDocument>(lpVtbl->get_ownerDocument)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return Marshal.GetDelegateForFunctionPointer<_cloneNode>(lpVtbl->cloneNode)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeTypeString>(lpVtbl->get_nodeTypeString)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_text>(lpVtbl->get_text)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_text>(lpVtbl->put_text)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_specified>(lpVtbl->get_specified)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_definition>(lpVtbl->get_definition)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeTypedValue>(lpVtbl->get_nodeTypedValue)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_nodeTypedValue>(lpVtbl->put_nodeTypedValue)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_dataType>(lpVtbl->get_dataType)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_dataType>(lpVtbl->put_dataType)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_xml>(lpVtbl->get_xml)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return Marshal.GetDelegateForFunctionPointer<_transformNode>(lpVtbl->transformNode)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return Marshal.GetDelegateForFunctionPointer<_selectNodes>(lpVtbl->selectNodes)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_selectSingleNode>(lpVtbl->selectSingleNode)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parsed>(lpVtbl->get_parsed)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_namespaceURI>(lpVtbl->get_namespaceURI)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_prefix>(lpVtbl->get_prefix)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_baseName>(lpVtbl->get_baseName)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_transformNodeToObject>(lpVtbl->transformNodeToObject)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] ushort** data)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_data>(lpVtbl->get_data)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] ushort* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_data>(lpVtbl->put_data)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_length>(lpVtbl->get_length)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), dataLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] ushort** data)
        {
            return Marshal.GetDelegateForFunctionPointer<_substringData>(lpVtbl->substringData)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] ushort* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_appendData>(lpVtbl->appendData)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_insertData>(lpVtbl->insertData)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return Marshal.GetDelegateForFunctionPointer<_deleteData>(lpVtbl->deleteData)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] ushort* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_replaceData>(lpVtbl->replaceData)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int splitText([NativeTypeName("long")] int offset, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** rightHandTextNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_splitText>(lpVtbl->splitText)((IXMLDOMCDATASection*)Unsafe.AsPointer(ref this), offset, rightHandTextNode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public IntPtr get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public IntPtr get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public IntPtr get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public IntPtr get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public IntPtr transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public IntPtr selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public IntPtr transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_data;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_data;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_length;

            [NativeTypeName("HRESULT (long, long, BSTR *) __attribute__((stdcall))")]
            public IntPtr substringData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr appendData;

            [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
            public IntPtr insertData;

            [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
            public IntPtr deleteData;

            [NativeTypeName("HRESULT (long, long, BSTR) __attribute__((stdcall))")]
            public IntPtr replaceData;

            [NativeTypeName("HRESULT (long, IXMLDOMText **) __attribute__((stdcall))")]
            public IntPtr splitText;
        }
    }
}
