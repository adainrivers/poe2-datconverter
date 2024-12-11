using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryCapturableMonsters
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryGroups")]
	public TRef BestiaryGroupsKey;

	[FieldOffset(32)]
	[ReferenceTable("BestiaryEncounters")]
	public TRef BestiaryEncountersKey;

	[FieldOffset(48)]
	public TBool Unk003;

	[FieldOffset(49)]
	public TString IconSmall;

	[FieldOffset(57)]
	public TString Icon;

	[FieldOffset(65)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Boss_MonsterVarietiesKey;

	[FieldOffset(81)]
	[ReferenceTable("BestiaryGenus")]
	public TRef BestiaryGenusKey;

	[FieldOffset(97)]
	public TBool Unk008;

	[FieldOffset(98)]
	[ReferenceTable("BestiaryCapturableMonsters")]
	public TRef BestiaryCapturableMonstersKey;

	[FieldOffset(106)]
	public TBool IsDisabled;

	[FieldOffset(107)]
	public int Unk011;

	[FieldOffset(111)]
	public TBool Unk012;

}
