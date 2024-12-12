namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveFeatures
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight;

	[FieldOffset(32)]
	[ReferenceTable("WorldAreas")]
	public TableReference WorldAreasKey;

	[FieldOffset(48)]
	public StringReference Image;

	[FieldOffset(56)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public ArrayReference MinDepth;

	[FieldOffset(104)]
	public StringReference Description;

	[FieldOffset(112)]
	public int Unk009;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(132)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

	[FieldOffset(148)]
	[ElementType(typeof(int))]
	public ArrayReference Unk012;

	[FieldOffset(164)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

}
