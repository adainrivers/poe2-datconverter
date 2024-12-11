using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTargets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BetrayalRanks")]
	public TRef BetrayalRanksKey;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(40)]
	[ReferenceTable("BetrayalJobs")]
	public TRef BetrayalJobsKey;

	[FieldOffset(56)]
	public TString Art;

	[FieldOffset(64)]
	public TBool Unk005;

	[FieldOffset(65)]
	[ReferenceTable("ItemClasses")]
	public TRef ItemClasses;

	[FieldOffset(81)]
	public TString FullName;

	[FieldOffset(89)]
	public TString Safehouse_ARMFile;

	[FieldOffset(97)]
	public TString ShortName;

	[FieldOffset(105)]
	public int Unk010;

	[FieldOffset(109)]
	[ReferenceTable("AchievementItems")]
	public TRef SafehouseLeader_AcheivementItemsKey;

	[FieldOffset(125)]
	[ReferenceTable("AchievementItems")]
	public TRef Level3_AchievementItemsKey;

	[FieldOffset(141)]
	public int Unk013;

	[FieldOffset(145)]
	public int Unk014;

	[FieldOffset(149)]
	public int Unk015;

	[FieldOffset(153)]
	public TRef Unk016;

	[FieldOffset(169)]
	public TString ScriptArgument;

}
