using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Maps
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference MapKeyTier;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TableReference SomeRef02;

    [FieldOffset(32)] public long UnkLong01;
    [FieldOffset(40)] public long UnkLong02;

    [FieldOffset(48)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference SomeRef03;

	[FieldOffset(64)]
	public long UnkLong03;

    [FieldOffset(72)]
    public long UnkLong04;

    [FieldOffset(80)]
    public TBool Unk015;

	[FieldOffset(81)]
	public TBool Unk016;

	[FieldOffset(82)]
	public TBool Unk017;

}
