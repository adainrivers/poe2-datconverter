namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalDialogue
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public ArrayReference Unk003;

	[FieldOffset(40)]
	[ReferenceTable("BetrayalTargets")]
	public TableReference BetrayalTargetsKey;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public TableReference Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk007;

	[FieldOffset(92)]
	[ReferenceTable("BetrayalUpgrades")]
	public TableReference BetrayalUpgradesKey;

	[FieldOffset(108)]
	public TBool Unk009;

	[FieldOffset(109)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(125)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk011;

	[FieldOffset(141)]
	public TBool Unk012;

	[FieldOffset(142)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(158)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference NPCTextAudioKey;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public ArrayReference Unk015;

}
