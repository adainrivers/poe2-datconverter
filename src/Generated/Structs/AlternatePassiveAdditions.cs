namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternatePassiveAdditions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("AlternateTreeVersions")]
	public TableReference AlternateTreeVersionsKey;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(44)]
	public int Stat1Min;

	[FieldOffset(48)]
	public int Stat1Max;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public int Unk007;

	[FieldOffset(60)]
	public int Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	[ElementType(typeof(int))]
	public ArrayReference PassiveType;

	[FieldOffset(84)]
	public int Unk011;

}
