using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumPersistentEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(40)]
	public TString Name;

	[FieldOffset(48)]
	public TString Icon;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public bool Unk006;

	[FieldOffset(61)]
	[ReferenceTable("SanctumPersistentEffectCategories")]
	public TRef EffectCategory;

	[FieldOffset(77)]
	[ReferenceTable("SanctumPersistentEffects")]
	public TRef NextEffect;

	[FieldOffset(85)]
	public TString Unk009;

	[FieldOffset(93)]
	public TString BoonDesc;

	[FieldOffset(101)]
	public TString CurseDesc;

	[FieldOffset(109)]
	public int Unk012;

	[FieldOffset(113)]
	public int Unk013;

	[FieldOffset(117)]
	public bool Unk014;

	[FieldOffset(118)]
	[ElementType(typeof(TRef))]
	public TArray Unk015;

	[FieldOffset(134)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Guard;

	[FieldOffset(150)]
	[ReferenceTable("SanctumPersistentEffects")]
	public TRef FirstEffect;

	[FieldOffset(158)]
	public int Unk018;

	[FieldOffset(162)]
	public int Unk019;

	[FieldOffset(166)]
	public bool Unk020;

	[FieldOffset(167)]
	public bool Unk021;

	[FieldOffset(168)]
	public int HASH16;

}
