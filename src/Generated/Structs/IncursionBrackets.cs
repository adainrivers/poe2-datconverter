using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct IncursionBrackets
{
	[FieldOffset(0)]
	public int MinLevel;

	[FieldOffset(4)]
	[ReferenceTable("WorldAreas")]
	public TRef Incursion_WorldAreasKey;

	[FieldOffset(20)]
	[ReferenceTable("WorldAreas")]
	public TRef Template_WorldAreasKey;

	[FieldOffset(36)]
	[ElementType(typeof(float))]
	public TArray Unk003;

	[FieldOffset(52)]
	public float Unk004;

	[FieldOffset(56)]
	public int Unk005;

}
