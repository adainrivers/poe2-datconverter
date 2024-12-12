namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumEncounters
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Description;

	[FieldOffset(16)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModTypes;

	[FieldOffset(32)]
	public StringReference BossARMFile;

	[FieldOffset(40)]
	[ReferenceTable("UltimatumEncounterTypes")]
	public TableReference Type;

	[FieldOffset(56)]
	public StringReference Icon;

	[FieldOffset(64)]
	public int HASH16;

	[FieldOffset(68)]
	public TBool Unk007;

	[FieldOffset(69)]
	public int Unk008;

	[FieldOffset(73)]
	public TBool Unk009;

}
