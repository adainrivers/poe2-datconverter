using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NearbyMonsterConditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys;

	[FieldOffset(24)]
	public int MonsterAmount;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public bool IsNegated;

	[FieldOffset(33)]
	public int Unk005;

	[FieldOffset(37)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(53)]
	public bool IsLessThen;

	[FieldOffset(54)]
	public int MinimumHealthPercentage;

}
