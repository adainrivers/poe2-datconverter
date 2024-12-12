namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GamepadButtonCombination
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("GamepadButton")]
	public TableReference Button1;

	[FieldOffset(24)]
	[ReferenceTable("GamepadButton")]
	public TableReference Button2;

	[FieldOffset(40)]
	public int Unk003;

}
