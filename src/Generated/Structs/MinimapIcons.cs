namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinimapIcons
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int MinimapIconRadius;

	[FieldOffset(12)]
	public int LargemapIconRadius;

	[FieldOffset(16)]
	public TBool Unk003;

	[FieldOffset(17)]
	public TBool Unk004;

	[FieldOffset(18)]
	public TBool Unk005;

	[FieldOffset(19)]
	public int MinimapIconPointerMaxDistance;

	[FieldOffset(23)]
	public int Unk007;

}
