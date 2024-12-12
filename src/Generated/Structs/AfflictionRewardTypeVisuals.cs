namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionRewardTypeVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("AfflictionRewardTypes")]
	[EnumName("AfflictionRewardTypes")]
	public TEnum AfflictionRewardTypes;

	[FieldOffset(4)]
	public StringReference Id;

	[FieldOffset(12)]
	public StringReference Name;

}
