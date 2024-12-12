namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Music
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference SoundFile;

	[FieldOffset(16)]
	public StringReference BankFile;

	[FieldOffset(24)]
	public int HASH16;

	[FieldOffset(28)]
	public TBool IsAvailableInHideout;

	[FieldOffset(29)]
	public StringReference Name;

	[FieldOffset(37)]
	public StringReference Unk006;

	[FieldOffset(45)]
	[ReferenceTable("MusicCategories")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MusicCategories;

	[FieldOffset(61)]
	public TBool Unk008;

	[FieldOffset(62)]
	public int Unk009;

}
