namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicroMigrationData
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TableReference Unk002;

	[FieldOffset(36)]
	public TableReference Unk003;

}
