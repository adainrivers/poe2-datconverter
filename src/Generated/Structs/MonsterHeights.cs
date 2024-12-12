namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterHeights
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVariety;

	[FieldOffset(16)]
	public float Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MonsterHeightBrackets")]
	public TableReference MonsterHeightBracket;

	[FieldOffset(36)]
	public int Unk003;

	[FieldOffset(40)]
	public int Unk004;

}
