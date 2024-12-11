using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscBeams
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TRef))]
	public TArray PreloadGroupsKeys;

	[FieldOffset(44)]
	public int Unk004;

}
