namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutNPCs
{
	[FieldOffset(0)]
	[ReferenceTable("NPCs")]
	public TableReference Hideout_NPCsKey;

	[FieldOffset(16)]
	[ReferenceTable("NPCs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Regular_NPCsKeys;

	[FieldOffset(32)]
	[ReferenceTable("HideoutDoodads")]
	public TableReference HideoutDoodadsKey;

	[FieldOffset(48)]
	public int NPCMasterKey;

	[FieldOffset(52)]
	public TableReference Unk004;

	[FieldOffset(68)]
	public TableReference Unk005;

	[FieldOffset(84)]
	public int Unk006;

	[FieldOffset(88)]
	public TableReference Unk007;

	[FieldOffset(104)]
	public int Unk008;

	[FieldOffset(108)]
	public TBool Unk009;

	[FieldOffset(109)]
	public TableReference Unk010;

}
