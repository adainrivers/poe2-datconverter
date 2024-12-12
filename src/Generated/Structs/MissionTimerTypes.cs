namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MissionTimerTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Image;

	[FieldOffset(16)]
	public StringReference BackgroundImage;

	[FieldOffset(24)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(40)]
	[ElementType(typeof(float))]
	public ArrayReference Unk004;

	[FieldOffset(56)]
	public TableReference Unk005;

	[FieldOffset(72)]
	public TableReference Unk006;

}
