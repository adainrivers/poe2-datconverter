namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponClasses
{
	[FieldOffset(0)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClass;

	[FieldOffset(16)]
	public int Unk001;

}
