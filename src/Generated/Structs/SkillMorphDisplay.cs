namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillMorphDisplay
{
	[FieldOffset(0)]
	public TableReference Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(TableReference))]
	public ArrayReference Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(StringReference))]
	public ArrayReference DDSFiles;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	[ElementType(typeof(float))]
	public ArrayReference Unk006;

	[FieldOffset(88)]
	public TBool Unk007;

	[FieldOffset(89)]
	public TBool Unk008;

}
