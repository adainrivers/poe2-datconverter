namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Hideouts
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference HideoutArea;

	[FieldOffset(16)]
	public short HASH16;

	[FieldOffset(18)]
	public StringReference HideoutFile;

	[FieldOffset(26)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SpawnAreas;

	[FieldOffset(42)]
	[ReferenceTable("WorldAreas")]
	public TableReference ClaimSideArea;

	[FieldOffset(58)]
	public StringReference HideoutImage;

	[FieldOffset(66)]
	public TBool IsEnabled;

	[FieldOffset(67)]
	public int Weight;

	[FieldOffset(71)]
	[ReferenceTable("HideoutRarity")]
	public TableReference Rarity;

	[FieldOffset(87)]
	public TBool NotActsArea;

	[FieldOffset(88)]
	public StringReference Name;

	[FieldOffset(96)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(112)]
	public TBool Unk012;

	[FieldOffset(113)]
	public TBool Unk013;

	[FieldOffset(114)]
	public TBool Unk014;

	[FieldOffset(115)]
	public TBool Unk015;

	[FieldOffset(116)]
	public StringReference ErrorMessage;

}
