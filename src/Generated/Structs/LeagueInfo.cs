namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueInfo
{
	[FieldOffset(0)]
	[ReferenceTable("LeagueInfoPanelVersions")]
	public TableReference PanelVersion;

	[FieldOffset(16)]
	public StringReference PanelId;

	[FieldOffset(24)]
	public StringReference PanelImage;

	[FieldOffset(32)]
	public StringReference HeaderImage;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Screenshots;

	[FieldOffset(56)]
	public StringReference Description;

	[FieldOffset(64)]
	public TBool Unk006;

	[FieldOffset(65)]
	public StringReference TrailerVideoLink;

	[FieldOffset(73)]
	public StringReference BackgroundImage;

	[FieldOffset(81)]
	public TBool Unk009;

	[FieldOffset(82)]
	public TBool Unk010;

	[FieldOffset(83)]
	[ElementType(typeof(StringReference))]
	public ArrayReference PanelItems;

	[FieldOffset(99)]
	public StringReference Unk012;

}
