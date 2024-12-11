using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct RitualRuneTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey1;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	public int LevelMin;

	[FieldOffset(32)]
	public int LevelMax;

	[FieldOffset(36)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public TArray BuffStatValues;

	[FieldOffset(68)]
	[ReferenceTable("RitualSpawnPatterns")]
	[ElementType(typeof(TRef))]
	public TArray SpawnPatterns;

	[FieldOffset(84)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKey;

	[FieldOffset(100)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(116)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(132)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey2;

	[FieldOffset(148)]
	[ReferenceTable("Environments")]
	public TRef EnvironmentsKey;

	[FieldOffset(164)]
	public int Unk013;

	[FieldOffset(168)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(184)]
	public TString Type;

	[FieldOffset(192)]
	public TString Description;

	[FieldOffset(200)]
	[ReferenceTable("DaemonSpawningData")]
	public TRef DaemonSpawningDataKey;

	[FieldOffset(216)]
	public TBool Unk018;

}
