namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BeyondFactions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Boss;

	[FieldOffset(24)]
	public TableReference Unk002;

}
