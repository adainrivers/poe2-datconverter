namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapConnections
{
	[FieldOffset(0)]
	[ReferenceTable("MapPins")]
	public TableReference MapPinsKey0;

	[FieldOffset(16)]
	[ReferenceTable("MapPins")]
	public TableReference MapPinsKey1;

	[FieldOffset(32)]
	public TableReference Unk002;

	[FieldOffset(48)]
	public StringReference RestrictedAreaText;

	[FieldOffset(56)]
	public TableReference Unk004;

	[FieldOffset(72)]
	public TableReference Unk005;

	[FieldOffset(88)]
	public TableReference Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(int))]
	public ArrayReference Unk007;

}
