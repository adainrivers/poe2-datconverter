using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterHeights
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVariety;

	[FieldOffset(16)]
	public float Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MonsterHeightBrackets")]
	public TRef MonsterHeightBracket;

	[FieldOffset(36)]
	public int Unk003;

	[FieldOffset(40)]
	public int Unk004;

}
