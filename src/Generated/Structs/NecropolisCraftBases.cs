namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisCraftBases
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

	[FieldOffset(24)]
	[ReferenceTable("NecropolisUniqueCrafts")]
	public TableReference UniqueCraft;

	[FieldOffset(40)]
	public TBool Unk003;

	[FieldOffset(41)]
	public int Unk004;

	[FieldOffset(45)]
	[ReferenceTable("NecropolisCraftItemTypes")]
	public TableReference CraftItemType;

	[FieldOffset(61)]
	public StringReference Name;

	[FieldOffset(69)]
	[ReferenceTable("Stats")]
	public TableReference CraftTag;

	[FieldOffset(85)]
	public TBool Unk008;

}
