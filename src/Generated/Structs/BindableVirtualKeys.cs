namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BindableVirtualKeys
{
	[FieldOffset(0)]
	public int KeyCode;

	[FieldOffset(4)]
	public StringReference Name;

	[FieldOffset(12)]
	public StringReference Id;

}
