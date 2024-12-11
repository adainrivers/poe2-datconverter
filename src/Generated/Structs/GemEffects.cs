using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffect;

	[FieldOffset(32)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffectHardmode;

	[FieldOffset(48)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffect2;

	[FieldOffset(64)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffect2Hardmode;

	[FieldOffset(80)]
	public TString SupportText;

	[FieldOffset(88)]
	public TString SupportName;

	[FieldOffset(96)]
	[ReferenceTable("GemTags")]
	[ElementType(typeof(TRef))]
	public TArray GemTags;

	[FieldOffset(112)]
	[ReferenceTable("Mods")]
	public TRef Consumed_ModsKey;

	[FieldOffset(128)]
	public int ItemColor;

}
