using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapePassiveTree
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int AllocationsRequired;

	[FieldOffset(12)]
	[ReferenceTable("HellscapePassives")]
	[ElementType(typeof(TRef))]
	public TArray Passives;

}
