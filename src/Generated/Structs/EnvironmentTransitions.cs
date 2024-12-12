namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EnvironmentTransitions
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(StringReference))]
	public ArrayReference OTFiles;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk002;

}
