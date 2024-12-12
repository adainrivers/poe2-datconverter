namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasNode
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey;

	[FieldOffset(32)]
	public TBool Unk002;

	[FieldOffset(33)]
	[ReferenceTable("Maps")]
	public TableReference MapsKey;

	[FieldOffset(49)]
	[ReferenceTable("FlavourText")]
	public TableReference FlavourTextKey;

	[FieldOffset(65)]
	[ReferenceTable("AtlasNode")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AtlasNodeKeys;

	[FieldOffset(81)]
	public int Tier0;

	[FieldOffset(85)]
	public int Tier1;

	[FieldOffset(89)]
	public int Tier2;

	[FieldOffset(93)]
	public int Tier3;

	[FieldOffset(97)]
	public int Tier4;

	[FieldOffset(101)]
	public float Unk011;

	[FieldOffset(105)]
	public float Unk012;

	[FieldOffset(109)]
	public float Unk013;

	[FieldOffset(113)]
	public float Unk014;

	[FieldOffset(117)]
	public float Unk015;

	[FieldOffset(121)]
	public StringReference DDSFile;

	[FieldOffset(129)]
	public TBool Unk017;

	[FieldOffset(130)]
	public TBool NotOnAtlas;

	[FieldOffset(131)]
	public int Unk019;

	[FieldOffset(135)]
	public int Unk020;

	[FieldOffset(139)]
	public int Unk021;

	[FieldOffset(143)]
	public int Unk022;

	[FieldOffset(147)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TableReference))]
	public ArrayReference DivCards;

}
