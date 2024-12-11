using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WarbandsPackMonsters
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public TBool Unk002;

	[FieldOffset(13)]
	public TBool Unk003;

	[FieldOffset(14)]
	public TBool Unk004;

	[FieldOffset(15)]
	public TBool Unk005;

	[FieldOffset(16)]
	public int Unk006;

	[FieldOffset(20)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Tier4_MonsterVarietiesKeys;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Tier3_MonsterVarietiesKeys;

	[FieldOffset(52)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Tier2_MonsterVarietiesKeys;

	[FieldOffset(68)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Tier1_MonsterVarietiesKeys;

	[FieldOffset(84)]
	public TString Tier1Name;

	[FieldOffset(92)]
	public TString Tier2Name;

	[FieldOffset(100)]
	public TString Tier3Name;

	[FieldOffset(108)]
	public TString Tier4Name;

	[FieldOffset(116)]
	public TString Tier1Art;

	[FieldOffset(124)]
	public TString Tier2Art;

	[FieldOffset(132)]
	public TString Tier3Art;

	[FieldOffset(140)]
	public TString Tier4Art;

}
