using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WorldAreas
{
    [FieldOffset(0)]
    public StringReference Id;

    [FieldOffset(8)]
    public StringReference Name;

    [FieldOffset(16)]
    public int Act;

    [FieldOffset(20)]
    public TBool IsTown;

    [FieldOffset(21)]
    public TBool HasWaypoint;

    [FieldOffset(22)]
    [ReferenceTable("WorldAreas")]
    [ElementType(typeof(TableReference))]
    public ArrayReference ConnectedWorldAreas;

    [FieldOffset(38)]
    public int AreaLevel;

    [FieldOffset(42)] 
    public long UnkLong01;

    [FieldOffset(52)]
    [ElementType(typeof(long))]
    public ArrayReference UnkArray01;

    [FieldOffset(68)]
    public TableReference UnkRef01;

    [FieldOffset(84)]
    [ElementType(typeof(long))]
    public ArrayReference UnkArray02;

    [FieldOffset(100)]
    public int UnkInt01;

    [FieldOffset(104)]
    [ElementType(typeof(TableReference))]
    [ReferenceTable("WorldAreas")]
    public ArrayReference SomehowConnectedAreasMaybe;
}
