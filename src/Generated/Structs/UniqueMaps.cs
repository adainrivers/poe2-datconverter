namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueMaps
{
	[FieldOffset(0)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(32)]
	[ReferenceTable("Words")]
	public TableReference WordsKey;

	[FieldOffset(48)]
	[ReferenceTable("FlavourText")]
	public TableReference FlavourTextKey;

	[FieldOffset(64)]
	public TBool HasGuildCharacter;

	[FieldOffset(65)]
	public StringReference GuildCharacter;

	[FieldOffset(73)]
	public StringReference Name;

	[FieldOffset(81)]
	public TBool IsDropDisabled;

}
