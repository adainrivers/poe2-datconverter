namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterConditionalEffectPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MiscEffectPack1;

	[FieldOffset(24)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MiscEffectPack2;

	[FieldOffset(40)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MiscEffectPack3;

	[FieldOffset(56)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MiscEffectPack4;

	[FieldOffset(72)]
	public int Unk005;

}
