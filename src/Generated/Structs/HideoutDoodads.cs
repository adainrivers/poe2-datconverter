namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HideoutDoodads
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Variation_AOFiles;

	[FieldOffset(32)]
	public TBool IsNonMasterDoodad;

	[FieldOffset(33)]
	public StringReference InheritsFrom;

	[FieldOffset(41)]
	public TBool Unk004;

	[FieldOffset(42)]
	public TBool IsCraftingBench;

	[FieldOffset(43)]
	[ReferenceTable("HideoutDoodadTags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tags;

	[FieldOffset(59)]
	public TBool Unk007;

	[FieldOffset(60)]
	public TableReference Unk008;

	[FieldOffset(76)]
	[ReferenceTable("HideoutDoodadCategory")]
	public TableReference Category;

	[FieldOffset(92)]
	public int Unk010;

	[FieldOffset(96)]
	public TBool Unk011;

	[FieldOffset(97)]
	public TableReference Unk012;

	[FieldOffset(113)]
	public TBool Unk013;

	[FieldOffset(114)]
	public TableReference Unk014;

	[FieldOffset(130)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk015;

	[FieldOffset(146)]
	public int Unk016;

	[FieldOffset(150)]
	public int Unk017;

	[FieldOffset(154)]
	public TBool Unk018;

	[FieldOffset(155)]
	public TBool Unk019;

}
