namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthTrinkets
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ReferenceTable("LabyrinthSecrets")]
	[ElementType(typeof(TableReference))]
	public ArrayReference LabyrinthSecretsKey;

	[FieldOffset(32)]
	[ReferenceTable("BuffDefinitions")]
	public TableReference Buff_BuffDefinitionsKey;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public ArrayReference Buff_StatValues;

}
