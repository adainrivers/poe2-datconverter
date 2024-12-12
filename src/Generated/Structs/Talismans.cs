namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Talismans
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(36)]
	public int Tier;

	[FieldOffset(40)]
	public TBool Unk004;

	[FieldOffset(41)]
	public TBool Unk005;

	[FieldOffset(42)]
	public TableReference Unk006;

	[FieldOffset(58)]
	public TableReference Unk007;

	[FieldOffset(74)]
	public int Unk008;

}
