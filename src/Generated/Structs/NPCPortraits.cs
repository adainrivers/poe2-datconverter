namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCPortraits
{
	[FieldOffset(0)]
	public StringReference Name;

	[FieldOffset(8)]
	public StringReference PortraitFile;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public int Unk003;

}
