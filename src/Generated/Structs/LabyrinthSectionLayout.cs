namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthSectionLayout
{
	[FieldOffset(0)]
	[ReferenceTable("LabyrinthSection")]
	public TableReference LabyrinthSectionKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("LabyrinthSectionLayout")]
	[ElementType(typeof(TableReference))]
	public ArrayReference LabyrinthSectionLayoutKeys;

	[FieldOffset(36)]
	[ReferenceTable("LabyrinthSecrets")]
	public TableReference LabyrinthSecretsKey0;

	[FieldOffset(52)]
	[ReferenceTable("LabyrinthSecrets")]
	public TableReference LabyrinthSecretsKey1;

	[FieldOffset(68)]
	[ReferenceTable("LabyrinthAreas")]
	public TableReference LabyrinthAreasKey;

	[FieldOffset(84)]
	public float Float0;

	[FieldOffset(88)]
	public float Float1;

	[FieldOffset(92)]
	[ReferenceTable("LabyrinthNodeOverrides")]
	[ElementType(typeof(TableReference))]
	public ArrayReference LabyrinthNodeOverridesKeys;

}
