namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPacks
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference Icon;

	[FieldOffset(24)]
	public StringReference Description;

	[FieldOffset(32)]
	public StringReference PackLeader1;

	[FieldOffset(40)]
	public StringReference PackLeader2;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	public TableReference Mod;

}
