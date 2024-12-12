namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCs
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference Metadata;

	[FieldOffset(24)]
	public TableReference Unk003;

	[FieldOffset(40)]
	[ReferenceTable("NPCMaster")]
	public TableReference NPCMasterKey;

	[FieldOffset(56)]
	public StringReference ShortName;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCAudios1;

	[FieldOffset(84)]
	[ReferenceTable("NPCAudio")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NPCAudios2;

	[FieldOffset(100)]
	public short HASH16;

	[FieldOffset(102)]
	[ReferenceTable("NPCs")]
	public TableReference Unk010;

	[FieldOffset(110)]
	[ReferenceTable("NPCPortraits")]
	public TableReference Portrait;

	[FieldOffset(126)]
	[ReferenceTable("NPCDialogueStyles")]
	public TableReference DialogueStyle;

	[FieldOffset(142)]
	public TBool Unk013;

	[FieldOffset(143)]
	public TableReference Unk014;

	[FieldOffset(159)]
	public StringReference Gender;

	[FieldOffset(167)]
	public TBool Unk016;

}
