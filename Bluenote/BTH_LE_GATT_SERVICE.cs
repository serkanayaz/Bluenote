﻿// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;

namespace Bluenote
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BTH_LE_GATT_SERVICE
    {
        internal BTH_LE_UUID serviceUuid;
        internal ushort attributeHandle;
    }
}
