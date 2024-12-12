namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalismanPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterPacksKeys;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(48)]
	public TableReference Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public int Unk007;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	[ReferenceTable("MonsterPacks")]
	public TableReference MonsterPacksKey;

}
