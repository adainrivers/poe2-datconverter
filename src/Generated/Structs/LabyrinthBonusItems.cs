namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthBonusItems
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemType;

	[FieldOffset(16)]
	public int AreaLevel;

	[FieldOffset(20)]
	public StringReference LabyrinthName;

}
