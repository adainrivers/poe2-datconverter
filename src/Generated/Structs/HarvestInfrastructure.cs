namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestInfrastructure
{
	[FieldOffset(0)]
	public StringReference Object;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("ClientStrings")]
	public TableReference ClientStringsKey;

}
