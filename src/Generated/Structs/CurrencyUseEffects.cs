namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CurrencyUseEffects
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public StringReference BK2File;

	[FieldOffset(28)]
	public StringReference SoundFile;

	[FieldOffset(36)]
	public TBool Unk004;

	[FieldOffset(37)]
	public StringReference BK2File2;

	[FieldOffset(45)]
	public TBool Unk006;

	[FieldOffset(46)]
	public TableReference Unk007;

	[FieldOffset(62)]
	public float Unk008;

}
