namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AwardDisplay
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	public StringReference BackgroundImage;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public float Unk004;

	[FieldOffset(32)]
	public float Unk005;

	[FieldOffset(36)]
	public StringReference Unk006;

	[FieldOffset(44)]
	public StringReference Unk007;

	[FieldOffset(52)]
	public StringReference ForegroundImage;

	[FieldOffset(60)]
	public StringReference OGGFile;

	[FieldOffset(68)]
	public TableReference Unk010;

	[FieldOffset(84)]
	public int Unk011;

	[FieldOffset(88)]
	public StringReference Unk012;

	[FieldOffset(96)]
	public TBool Unk013;

}
