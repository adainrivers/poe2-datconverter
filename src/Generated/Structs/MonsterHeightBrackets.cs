using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterHeightBrackets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisuals1;

	[FieldOffset(28)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisuals2;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public float Unk005;

	[FieldOffset(52)]
	public float Unk006;

	[FieldOffset(56)]
	[ReferenceTable("Tags")]
	public TRef Tag;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	public float Unk009;

	[FieldOffset(80)]
	public float Unk010;

}
