namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterPanelDescriptionModes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Unk001;

	[FieldOffset(16)]
	public StringReference FormatString_Positive;

	[FieldOffset(24)]
	public StringReference FormatString_Negative;

}
