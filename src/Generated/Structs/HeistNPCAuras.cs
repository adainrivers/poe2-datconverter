namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCAuras
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TableReference Stat;

	[FieldOffset(16)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffect;

}
