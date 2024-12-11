using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SurgeTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("SurgeEffects")]
	[ElementType(typeof(TRef))]
	public TArray SurgeEffects;

	[FieldOffset(24)]
	public int IntId;

}
