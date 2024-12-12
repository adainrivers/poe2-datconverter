namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct JobRaidBrackets
{
	[FieldOffset(0)]
	public int MinLevel;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldArea;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public int Unk006;

}
