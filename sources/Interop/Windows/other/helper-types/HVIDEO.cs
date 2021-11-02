// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HVIDEO : IEquatable<HVIDEO>
    {
        public readonly nint Value;

        public HVIDEO(nint value)
        {
            Value = value;
        }

        public static HVIDEO INVALID_HANDLE_VALUE => new HVIDEO(-1);

        public static HVIDEO NULL => new HVIDEO(0);

        public static bool operator ==(HVIDEO left, HVIDEO right) => left.Value == right.Value;

        public static bool operator !=(HVIDEO left, HVIDEO right) => left.Value != right.Value;

        public static explicit operator HVIDEO(void* value) => new HVIDEO((nint)(value));

        public static implicit operator void*(HVIDEO value) => (void*)(value.Value);

        public static explicit operator HVIDEO(HANDLE value) => new HVIDEO(value);

        public static implicit operator HANDLE(HVIDEO value) => new HVIDEO(value);

        public static explicit operator HVIDEO(byte value) => new HVIDEO((nint)(value));

        public static explicit operator byte(HVIDEO value) => (byte)(value.Value);

        public static explicit operator HVIDEO(short value) => new HVIDEO((nint)(value));

        public static explicit operator short(HVIDEO value) => (short)(value.Value);

        public static explicit operator HVIDEO(int value) => new HVIDEO((nint)(value));

        public static explicit operator int(HVIDEO value) => (int)(value.Value);

        public static explicit operator HVIDEO(long value) => new HVIDEO((nint)(value));

        public static implicit operator long(HVIDEO value) => (long)(value.Value);

        public static explicit operator HVIDEO(nint value) => new HVIDEO((nint)(value));

        public static implicit operator nint(HVIDEO value) => (nint)(value.Value);

        public static explicit operator HVIDEO(sbyte value) => new HVIDEO((nint)(value));

        public static explicit operator sbyte(HVIDEO value) => (sbyte)(value.Value);

        public static explicit operator HVIDEO(ushort value) => new HVIDEO((nint)(value));

        public static explicit operator ushort(HVIDEO value) => (ushort)(value.Value);

        public static explicit operator HVIDEO(uint value) => new HVIDEO((nint)(value));

        public static explicit operator uint(HVIDEO value) => (uint)(value.Value);

        public static explicit operator HVIDEO(ulong value) => new HVIDEO((nint)(value));

        public static implicit operator ulong(HVIDEO value) => (ulong)(value.Value);

        public static explicit operator HVIDEO(nuint value) => new HVIDEO((nint)(value));

        public static explicit operator nuint(HVIDEO value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HVIDEO other) && Equals(other);

        public bool Equals(HVIDEO other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
