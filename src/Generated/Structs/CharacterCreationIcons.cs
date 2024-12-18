namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterCreationIcons
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
    public StringReference Type;

	[FieldOffset(16)]
    public StringReference Description;
	
	[FieldOffset(24)]
    public StringReference Video;

	[FieldOffset(32)]
	public StringReference Icon;
}