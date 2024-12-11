using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistObjectives
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemType;

	[FieldOffset(16)]
	public float Scaling;

	[FieldOffset(20)]
	public TString Name;

}
