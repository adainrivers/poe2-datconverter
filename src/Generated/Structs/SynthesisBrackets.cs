namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SynthesisBrackets
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey1;

	[FieldOffset(16)]
	public int MinLevel;

	[FieldOffset(20)]
	public int MaxLevel;

	[FieldOffset(24)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey2;

	[FieldOffset(40)]
	public int Unk004;

	[FieldOffset(44)]
	public int Unk005;

	[FieldOffset(48)]
	public int Unk006;

	[FieldOffset(52)]
	public int Unk007;

}
