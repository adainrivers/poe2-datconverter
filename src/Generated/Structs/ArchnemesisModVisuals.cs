using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisModVisuals
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TRef Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	public TRef Unk003;

	[FieldOffset(56)]
	[ReferenceTable("BuffVisuals")]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(72)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Unk005;

	[FieldOffset(88)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(TRef))]
	public TArray Unk007;

}
