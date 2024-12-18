namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DaemonSpawningData
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MonsterVarieties;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TBool Unk003;

	[FieldOffset(29)]
	public int Unk004;

	[FieldOffset(33)]
	public int Unk005;

	[FieldOffset(37)]
	public TBool Unk006;

	[FieldOffset(38)]
	public TBool Unk007;

	[FieldOffset(39)]
	public TBool Unk008;

}
