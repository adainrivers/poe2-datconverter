namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GenericLeagueRewardTypeVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("GenericLeagueRewardTypes")]
	public TableReference Type;

	[FieldOffset(16)]
	public TableReference Unk001;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public float Unk003;

	[FieldOffset(52)]
	public StringReference Icon;

	[FieldOffset(60)]
	public StringReference Name;

}
