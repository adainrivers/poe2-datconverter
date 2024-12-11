using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeMonsterPacks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	public TRef MonsterPack;

	[FieldOffset(24)]
	[ReferenceTable("HellscapeFactions")]
	public TRef Faction;

	[FieldOffset(40)]
	public bool IsDonutPack;

	[FieldOffset(41)]
	public bool IsElite;

	[FieldOffset(42)]
	public int MinLevel;

	[FieldOffset(46)]
	public int MaxLevel;

}
