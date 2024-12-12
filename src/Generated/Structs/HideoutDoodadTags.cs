namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutDoodadTags
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public ArrayReference Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(40)]
	public StringReference Name;

}
