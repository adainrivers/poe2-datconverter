using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SurgeEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TRef Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(float))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ElementType(typeof(TString))]
	public TArray Unk004;

}
