namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageUniqueDisenchantValues
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TableReference UniqueName;

	[FieldOffset(16)]
	public float Value;

}
