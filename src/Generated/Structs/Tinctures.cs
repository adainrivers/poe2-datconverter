namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Tinctures
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItem;

	[FieldOffset(16)]
	public int DebuffInterval;

	[FieldOffset(20)]
	public int Cooldown;

}
