namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NearbyMonsterConditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterVarietiesKeys;

	[FieldOffset(24)]
	public int MonsterAmount;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public TBool IsNegated;

	[FieldOffset(33)]
	public int Unk005;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(53)]
	public TBool IsLessThen;

	[FieldOffset(54)]
	public int MinimumHealthPercentage;

}
