// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_CPU_PAGE_PROPERTY;
using static TerraFX.Interop.DirectX.D3D12_HEAP_TYPE;
using static TerraFX.Interop.DirectX.D3D12_MEMORY_POOL;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES"]/*' />
[NativeTypeName("struct CD3DX12_HEAP_PROPERTIES : D3D12_HEAP_PROPERTIES")]
[NativeInheritance("D3D12_HEAP_PROPERTIES")]
public partial struct D3D12_HEAP_PROPERTIES
{
    public D3D12_HEAP_PROPERTIES(D3D12_CPU_PAGE_PROPERTY cpuPageProperty, D3D12_MEMORY_POOL memoryPoolPreference, uint creationNodeMask = 1, uint nodeMask = 1)
    {
        Type = D3D12_HEAP_TYPE_CUSTOM;
        CPUPageProperty = cpuPageProperty;
        MemoryPoolPreference = memoryPoolPreference;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public D3D12_HEAP_PROPERTIES(D3D12_HEAP_TYPE type, uint creationNodeMask = 1, uint nodeMask = 1)
    {
        Type = type;
        CPUPageProperty = D3D12_CPU_PAGE_PROPERTY_UNKNOWN;
        MemoryPoolPreference = D3D12_MEMORY_POOL_UNKNOWN;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public readonly bool IsCPUAccessible()
    {
        return Type == D3D12_HEAP_TYPE_UPLOAD || Type == D3D12_HEAP_TYPE_READBACK || Type == D3D12_HEAP_TYPE_GPU_UPLOAD || (Type == D3D12_HEAP_TYPE_CUSTOM && (CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE || CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_BACK));
    }
}
