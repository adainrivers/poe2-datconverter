namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LegionRewardTypeVisuals
{
	[FieldOffset(0)]
	public int IntId;

	[FieldOffset(4)]
	[ReferenceTable("MinimapIcons")]
	public TableReference MinimapIconsKey;

	[FieldOffset(20)]
	public StringReference Unk002;

	[FieldOffset(28)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimatedKey;

	[FieldOffset(44)]
	public float Unk004;

	[FieldOffset(48)]
	public StringReference Id;

}
