namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ComponentAttributeRequirements
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public StringReference BaseItemTypesKey;

	[FieldOffset(8)]
	public int ReqStr;

	[FieldOffset(12)]
	public int ReqDex;

	[FieldOffset(16)]
	public int ReqInt;

}
