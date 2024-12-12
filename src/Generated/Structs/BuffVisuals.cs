namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffVisuals
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference BuffDDSFile;

	[FieldOffset(16)]
	[ElementType(typeof(StringReference))]
	public ArrayReference EPKFiles1;

	[FieldOffset(32)]
	[ElementType(typeof(StringReference))]
	public ArrayReference EPKFiles2;

	[FieldOffset(48)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TableReference))]
	public ArrayReference PreloadGroups;

	[FieldOffset(64)]
	public TBool Unk005;

	[FieldOffset(65)]
	public StringReference BuffName;

	[FieldOffset(73)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated1;

	[FieldOffset(89)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated2;

	[FieldOffset(105)]
	public StringReference BuffDescription;

	[FieldOffset(113)]
	public StringReference EPKFile;

	[FieldOffset(121)]
	public TBool HasExtraArt;

	[FieldOffset(122)]
	public StringReference ExtraArt;

	[FieldOffset(130)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(146)]
	[ElementType(typeof(StringReference))]
	public ArrayReference EPKFiles;

	[FieldOffset(162)]
	[ReferenceTable("BuffVisualOrbs")]
	[ElementType(typeof(TableReference))]
	public ArrayReference BuffVisualOrbs;

	[FieldOffset(178)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated3;

	[FieldOffset(194)]
	public TableReference Unk017;

	[FieldOffset(210)]
	public StringReference Unk018;

}
