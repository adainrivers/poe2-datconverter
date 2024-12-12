namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeImmuneMonsters
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference Monster;

}
