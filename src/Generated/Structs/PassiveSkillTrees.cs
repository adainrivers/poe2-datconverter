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
	public TBool Unk006;

	[FieldOffset(33)]
	public TBool Unk007;

	[FieldOffset(34)]
	public TBool Unk008;

	[FieldOffset(35)]
	public TBool Unk009;

	[FieldOffset(36)]
	public TBool Unk010;

	[FieldOffset(37)]
	public TBool Unk011;

	[FieldOffset(38)]
	public TBool Unk012;

	[FieldOffset(39)]
	public TBool Unk013;

	[FieldOffset(40)]
	public TBool Unk014;

	[FieldOffset(41)]
	public TBool Unk015;

	[FieldOffset(42)]
	public TBool Unk016;

	[FieldOffset(43)]
	[ReferenceTable("ClientStrings")]
	public TRef Unk017;

	[FieldOffset(59)]
	[ReferenceTable("PassiveSkillTreeUIArt")]
	public TRef UIArt;

	[FieldOffset(75)]
	public TBool Unk019;

}
