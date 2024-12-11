using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTowersPerLevel
{
	[FieldOffset(0)]
	[ReferenceTable("BlightTowers")]
	public TRef BlightTowersKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(36)]
	public int Cost;

	[FieldOffset(40)]
	public int Unk004;

}
