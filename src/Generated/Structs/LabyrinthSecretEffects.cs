namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthSecretEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TableReference MonsterVarietiesKey;

	[FieldOffset(24)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference Buff_BuffDefinitionsKey;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Buff_StatValues;

	[FieldOffset(56)]
	public StringReference OTFile;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public ArrayReference Unk005;

}
