using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillSurgeEffects
{
	[FieldOffset(0)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffectsKey;

	[FieldOffset(16)]
	public TString Unk001;

	[FieldOffset(24)]
	public bool Unk002;

	[FieldOffset(25)]
	public bool Unk003;

	[FieldOffset(26)]
	public bool Unk004;

	[FieldOffset(27)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(43)]
	public bool Unk006;

	[FieldOffset(44)]
	public bool Unk007;

	[FieldOffset(45)]
	public int Unk008;

	[FieldOffset(49)]
	public bool Unk009;

	[FieldOffset(50)]
	public bool Unk010;

	[FieldOffset(51)]
	public bool Unk011;

	[FieldOffset(52)]
	public bool Unk012;

}
