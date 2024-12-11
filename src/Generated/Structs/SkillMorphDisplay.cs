using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillMorphDisplay
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(TString))]
	public TArray DDSFiles;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	[ElementType(typeof(float))]
	public TArray Unk006;

	[FieldOffset(88)]
	public TBool Unk007;

	[FieldOffset(89)]
	public TBool Unk008;

}
