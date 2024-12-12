namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SurgeTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("SurgeEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference SurgeEffects;

	[FieldOffset(24)]
	public int IntId;

}
