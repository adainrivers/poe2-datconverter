namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveBiomes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	[ElementType(typeof(TableReference))]
	public ArrayReference WorldAreasKeys;

	[FieldOffset(32)]
	public StringReference UIImage;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Depth;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public ArrayReference SpawnWeight_Values;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

	[FieldOffset(104)]
	public StringReference Art2D;

	[FieldOffset(112)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AchievementItemsKeys;

	[FieldOffset(128)]
	public TBool Unk010;

	[FieldOffset(129)]
	[ElementType(typeof(int))]
	public ArrayReference Unk011;

}
