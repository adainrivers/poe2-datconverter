using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterConditionalEffectPacks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TRef))]
	public TArray MiscEffectPack1;

	[FieldOffset(24)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TRef))]
	public TArray MiscEffectPack2;

	[FieldOffset(40)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TRef))]
	public TArray MiscEffectPack3;

	[FieldOffset(56)]
	[ReferenceTable("MiscEffectPacks")]
	[ElementType(typeof(TRef))]
	public TArray MiscEffectPack4;

	[FieldOffset(72)]
	public int Unk005;

}
