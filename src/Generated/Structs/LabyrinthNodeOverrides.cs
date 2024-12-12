namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthNodeOverrides
{
	[FieldOffset(0)]
	public StringReference Id1;

	[FieldOffset(8)]
	public StringReference Id2;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

}
