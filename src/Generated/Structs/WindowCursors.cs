namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WindowCursors
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference CursorDefault;

	[FieldOffset(16)]
	public StringReference CursorClick;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public StringReference CursorHover;

	[FieldOffset(40)]
	public StringReference Description;

	[FieldOffset(48)]
	public TBool IsEnabled;

	[FieldOffset(49)]
	public int Unk008;

}
