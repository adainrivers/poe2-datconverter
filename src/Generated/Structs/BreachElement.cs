namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BreachElement
{
	[FieldOffset(0)]
	public StringReference Element;

	[FieldOffset(8)]
	public TableReference Unk001;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseBreachstone;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TableReference BossMapMod;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TableReference DuplicateBoss;

}
