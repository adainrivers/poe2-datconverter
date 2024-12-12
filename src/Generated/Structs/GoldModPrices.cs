namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GoldModPrices
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Id;

	[FieldOffset(16)]
	public int Value;

	[FieldOffset(20)]
	public int Weight;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tags;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight;

	[FieldOffset(64)]
	public TableReference Unk007;

	[FieldOffset(80)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk008;

}
