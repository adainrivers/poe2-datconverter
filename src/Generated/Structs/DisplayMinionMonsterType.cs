using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DisplayMinionMonsterType
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

}
