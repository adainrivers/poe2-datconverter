namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeFactions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("Environments")]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ReferenceTable("Environments")]
	public TableReference Unk002;

	[FieldOffset(40)]
	[ReferenceTable("Environments")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk005;

	[FieldOffset(76)]
	public StringReference Unk006;

	[FieldOffset(84)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Boss;

}
