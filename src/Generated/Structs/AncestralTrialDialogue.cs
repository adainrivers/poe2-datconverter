using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialDialogue
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	[ReferenceTable("NPCTextAudio")]
	[ElementType(typeof(TRef))]
	public TArray TextAudio;

	[FieldOffset(52)]
	public TRef Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public int Unk007;

	[FieldOffset(80)]
	public int Unk008;

	[FieldOffset(84)]
	public int Unk009;

	[FieldOffset(88)]
	public int Unk010;

	[FieldOffset(92)]
	public int Unk011;

	[FieldOffset(96)]
	public int Unk012;

	[FieldOffset(100)]
	public TBool Unk013;

	[FieldOffset(101)]
	public TBool Unk014;

	[FieldOffset(102)]
	public TBool Unk015;

}
