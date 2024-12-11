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
	public TBool Unk002;

	[FieldOffset(25)]
	public TBool Unk003;

	[FieldOffset(26)]
	public TBool Unk004;

	[FieldOffset(27)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(43)]
	public TBool Unk006;

	[FieldOffset(44)]
	public TBool Unk007;

	[FieldOffset(45)]
	public int Unk008;

	[FieldOffset(49)]
	public TBool Unk009;

	[FieldOffset(50)]
	public TBool Unk010;

	[FieldOffset(51)]
	public TBool Unk011;

	[FieldOffset(52)]
	public TBool Unk012;

}
