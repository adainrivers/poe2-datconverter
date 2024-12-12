namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AnimateWeaponUniques
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentity;

	[FieldOffset(24)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClass;

	[FieldOffset(40)]
	public int Unk003;

}
