namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DropPool
{
	[FieldOffset(0)]
	public StringReference Group;

	[FieldOffset(8)]
	public int Weight;

	[FieldOffset(12)]
	[ElementType(typeof(int))]
	public ArrayReference Unk002;

	[FieldOffset(28)]
	public int WeightHardmode;

}
