namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelPassiveTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DefaultIcon;

	[FieldOffset(16)]
	public StringReference ActiveIcon;

	[FieldOffset(24)]
	[ReferenceTable("DroneTypes")]
	public TableReference DroneType;

	[FieldOffset(40)]
	public int Unk004;

}
