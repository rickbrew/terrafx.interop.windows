// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSWDEVICE : IEquatable<HSWDEVICE>
    {
        public readonly nint Value;

        public HSWDEVICE(nint value)
        {
            Value = value;
        }

        public static HSWDEVICE INVALID_HANDLE_VALUE => new HSWDEVICE(-1);

        public static HSWDEVICE NULL => new HSWDEVICE(0);

        public static bool operator ==(HSWDEVICE left, HSWDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSWDEVICE left, HSWDEVICE right) => left.Value != right.Value;

        public static explicit operator HSWDEVICE(void* value) => new HSWDEVICE((nint)(value));

        public static implicit operator void*(HSWDEVICE value) => (void*)(value.Value);

        public static explicit operator HSWDEVICE(HANDLE value) => new HSWDEVICE(value);

        public static implicit operator HANDLE(HSWDEVICE value) => new HSWDEVICE(value);

        public static explicit operator HSWDEVICE(byte value) => new HSWDEVICE((nint)(value));

        public static explicit operator byte(HSWDEVICE value) => (byte)(value.Value);

        public static explicit operator HSWDEVICE(short value) => new HSWDEVICE((nint)(value));

        public static explicit operator short(HSWDEVICE value) => (short)(value.Value);

        public static explicit operator HSWDEVICE(int value) => new HSWDEVICE((nint)(value));

        public static explicit operator int(HSWDEVICE value) => (int)(value.Value);

        public static explicit operator HSWDEVICE(long value) => new HSWDEVICE((nint)(value));

        public static implicit operator long(HSWDEVICE value) => (long)(value.Value);

        public static explicit operator HSWDEVICE(nint value) => new HSWDEVICE((nint)(value));

        public static implicit operator nint(HSWDEVICE value) => (nint)(value.Value);

        public static explicit operator HSWDEVICE(sbyte value) => new HSWDEVICE((nint)(value));

        public static explicit operator sbyte(HSWDEVICE value) => (sbyte)(value.Value);

        public static explicit operator HSWDEVICE(ushort value) => new HSWDEVICE((nint)(value));

        public static explicit operator ushort(HSWDEVICE value) => (ushort)(value.Value);

        public static explicit operator HSWDEVICE(uint value) => new HSWDEVICE((nint)(value));

        public static explicit operator uint(HSWDEVICE value) => (uint)(value.Value);

        public static explicit operator HSWDEVICE(ulong value) => new HSWDEVICE((nint)(value));

        public static implicit operator ulong(HSWDEVICE value) => (ulong)(value.Value);

        public static explicit operator HSWDEVICE(nuint value) => new HSWDEVICE((nint)(value));

        public static explicit operator nuint(HSWDEVICE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSWDEVICE other) && Equals(other);

        public bool Equals(HSWDEVICE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
