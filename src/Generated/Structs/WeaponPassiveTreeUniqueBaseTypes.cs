namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponPassiveTreeUniqueBaseTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference UniqueBase;

	[FieldOffset(16)]
	public int Unk001;

}
