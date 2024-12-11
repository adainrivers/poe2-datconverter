using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TormentSpirits
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Spirit_ModsKeys;

	[FieldOffset(32)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Touched_ModsKeys;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray Possessed_ModsKeys;

	[FieldOffset(64)]
	public int MinZoneLevel;

	[FieldOffset(68)]
	public int MaxZoneLevel;

	[FieldOffset(72)]
	public int SpawnWeight;

	[FieldOffset(76)]
	[ReferenceTable("MonsterVarieties")]
	public TRef SummonedMonster_MonsterVarietiesKey;

	[FieldOffset(92)]
	public int Unk008;

	[FieldOffset(96)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys0;

	[FieldOffset(112)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys1;

}
