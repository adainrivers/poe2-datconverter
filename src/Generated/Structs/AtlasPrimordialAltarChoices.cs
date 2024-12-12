namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialAltarChoices
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

	[FieldOffset(16)]
	[ReferenceTable("AtlasPrimordialAltarChoiceTypes")]
	public TableReference Type;

	[FieldOffset(32)]
	public TBool Unk002;

}
