namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCDialogueStyles
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference HeaderBaseFile;

	[FieldOffset(16)]
	public StringReference ButtomFile;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference BannerFiles;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference HeaderFiles;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public int Unk006;

	[FieldOffset(64)]
	public int Unk007;

	[FieldOffset(68)]
	public int Unk008;

	[FieldOffset(72)]
	public int Unk009;

	[FieldOffset(76)]
	[ElementType(typeof(int))]
	public ArrayReference Unk010;

	[FieldOffset(92)]
	[ReferenceTable("NPCDialogueStyles")]
	public TableReference Unk011;

	[FieldOffset(100)]
	public StringReference Unk012;

	[FieldOffset(108)]
	[ElementType(typeof(int))]
	public ArrayReference Unk013;

	[FieldOffset(124)]
	[ElementType(typeof(int))]
	public ArrayReference Unk014;

	[FieldOffset(140)]
	public int Unk015;

	[FieldOffset(144)]
	public int Unk016;

	[FieldOffset(148)]
	public float Unk017;

	[FieldOffset(152)]
	public StringReference Unk018;

	[FieldOffset(160)]
	public StringReference Unk019;

	[FieldOffset(168)]
	public int Unk020;

	[FieldOffset(172)]
	public int Unk021;

}
