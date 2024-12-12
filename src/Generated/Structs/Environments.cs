namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Environments
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Base_ENVFile;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Corrupted_ENVFiles;

	[FieldOffset(32)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk003;

	[FieldOffset(48)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk004;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

	[FieldOffset(80)]
	[ReferenceTable("EnvironmentTransitions")]
	public TableReference EnvironmentTransitionsKey;

	[FieldOffset(96)]
	[ReferenceTable("PreloadGroups")]
	public TableReference PreloadGroup;

}
