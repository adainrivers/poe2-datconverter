using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeImmuneMonsters
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Monster;

}
