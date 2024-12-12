namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SpectreOverrides
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Monster;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Spectre;

	[FieldOffset(32)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk002;

}
