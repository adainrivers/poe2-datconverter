namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Commands
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Command;

	[FieldOffset(16)]
	public TBool Unk002;

	[FieldOffset(17)]
	public StringReference EnglishCommand;

	[FieldOffset(25)]
	public StringReference Description;

	[FieldOffset(33)]
	public TBool Unk005;

}
