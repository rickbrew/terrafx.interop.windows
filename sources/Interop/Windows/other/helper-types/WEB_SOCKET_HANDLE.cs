// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WEB_SOCKET_HANDLE : IEquatable<WEB_SOCKET_HANDLE>
    {
        public readonly nint Value;

        public WEB_SOCKET_HANDLE(nint value)
        {
            Value = value;
        }

        public static WEB_SOCKET_HANDLE INVALID_HANDLE_VALUE => new WEB_SOCKET_HANDLE(-1);

        public static WEB_SOCKET_HANDLE NULL => new WEB_SOCKET_HANDLE(0);

        public static bool operator ==(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(WEB_SOCKET_HANDLE left, WEB_SOCKET_HANDLE right) => left.Value != right.Value;

        public static explicit operator WEB_SOCKET_HANDLE(void* value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static implicit operator void*(WEB_SOCKET_HANDLE value) => (void*)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(HANDLE value) => new WEB_SOCKET_HANDLE(value);

        public static implicit operator HANDLE(WEB_SOCKET_HANDLE value) => new WEB_SOCKET_HANDLE(value);

        public static explicit operator WEB_SOCKET_HANDLE(byte value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator byte(WEB_SOCKET_HANDLE value) => (byte)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(short value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator short(WEB_SOCKET_HANDLE value) => (short)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(int value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator int(WEB_SOCKET_HANDLE value) => (int)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(long value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static implicit operator long(WEB_SOCKET_HANDLE value) => (long)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(nint value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static implicit operator nint(WEB_SOCKET_HANDLE value) => (nint)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(sbyte value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator sbyte(WEB_SOCKET_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(ushort value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator ushort(WEB_SOCKET_HANDLE value) => (ushort)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(uint value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator uint(WEB_SOCKET_HANDLE value) => (uint)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(ulong value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static implicit operator ulong(WEB_SOCKET_HANDLE value) => (ulong)(value.Value);

        public static explicit operator WEB_SOCKET_HANDLE(nuint value) => new WEB_SOCKET_HANDLE((nint)(value));

        public static explicit operator nuint(WEB_SOCKET_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is WEB_SOCKET_HANDLE other) && Equals(other);

        public bool Equals(WEB_SOCKET_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
