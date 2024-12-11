using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestCraftOptions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Text;

	[FieldOffset(16)]
	[ReferenceTable("HarvestCraftTiers")]
	public TRef Tier;

	[FieldOffset(32)]
	public TString Command;

	[FieldOffset(40)]
	public TString Parameters;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(64)]
	public short HASH16;

	[FieldOffset(66)]
	public TString Description;

	[FieldOffset(74)]
	public TBool IsEnchant;

	[FieldOffset(75)]
	public int LifeforceType;

	[FieldOffset(79)]
	public int LifeforceCost;

	[FieldOffset(83)]
	public int SacredCost;

	[FieldOffset(87)]
	public TBool Unk012;

	[FieldOffset(88)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievements;

	[FieldOffset(104)]
	public int Unk014;

}
