using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTrees
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString PassiveSkillGraph;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public float Unk003;

	[FieldOffset(24)]
	public float Unk004;

	[FieldOffset(28)]
	public float Unk005;

	[FieldOffset(32)]
	public bool Unk006;

	[FieldOffset(33)]
	public bool Unk007;

	[FieldOffset(34)]
	public bool Unk008;

	[FieldOffset(35)]
	public bool Unk009;

	[FieldOffset(36)]
	public bool Unk010;

	[FieldOffset(37)]
	public bool Unk011;

	[FieldOffset(38)]
	public bool Unk012;

	[FieldOffset(39)]
	public bool Unk013;

	[FieldOffset(40)]
	public bool Unk014;

	[FieldOffset(41)]
	public bool Unk015;

	[FieldOffset(42)]
	public bool Unk016;

	[FieldOffset(43)]
	[ReferenceTable("ClientStrings")]
	public TRef Unk017;

	[FieldOffset(59)]
	[ReferenceTable("PassiveSkillTreeUIArt")]
	public TRef UIArt;

	[FieldOffset(75)]
	public bool Unk019;

}
