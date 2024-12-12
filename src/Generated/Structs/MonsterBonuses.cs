namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterBonuses
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	public TableReference Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(88)]
	public TBool Unk006;

	[FieldOffset(89)]
	public TBool Unk007;

	[FieldOffset(90)]
	public TBool Unk008;

	[FieldOffset(91)]
	public TBool Unk009;

}
