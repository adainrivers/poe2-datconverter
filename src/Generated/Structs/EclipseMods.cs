namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EclipseMods
{
	[FieldOffset(0)]
	public StringReference Key;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnWeight_TagsKeys;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(40)]
	[ReferenceTable("Mods")]
	public TableReference ModsKey;

	[FieldOffset(56)]
	public int MinLevel;

	[FieldOffset(60)]
	public int MaxLevel;

	[FieldOffset(64)]
	public TBool IsPrefix;

}
