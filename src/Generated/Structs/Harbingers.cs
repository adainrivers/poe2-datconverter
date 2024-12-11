using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Harbingers
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int MinLevel;

	[FieldOffset(24)]
	public int MaxLevel;

	[FieldOffset(28)]
	public int Unk004;

}
