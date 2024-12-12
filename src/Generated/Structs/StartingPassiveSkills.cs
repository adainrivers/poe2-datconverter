namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StartingPassiveSkills
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("PassiveSkills")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PassiveSkills;

}
