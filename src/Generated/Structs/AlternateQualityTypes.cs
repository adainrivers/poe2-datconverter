namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternateQualityTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference Item;

	[FieldOffset(32)]
	public TableReference Unk003;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MapStats;

	[FieldOffset(64)]
	public int Unk005;

	[FieldOffset(68)]
	public TBool IsCatalyst;

	[FieldOffset(69)]
	public short HASH16;

	[FieldOffset(71)]
	[ReferenceTable("Mods")]
	public TableReference CatalystMod;

}
