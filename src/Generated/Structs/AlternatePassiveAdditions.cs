using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternatePassiveAdditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("AlternateTreeVersions")]
	public TRef AlternateTreeVersionsKey;

	[FieldOffset(24)]
	public int SpawnWeight;

	[FieldOffset(28)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(44)]
	public int Stat1Min;

	[FieldOffset(48)]
	public int Stat1Max;

	[FieldOffset(52)]
	public int Unk006;

	[FieldOffset(56)]
	public int Unk007;

	[FieldOffset(60)]
	public int Unk008;

	[FieldOffset(64)]
	public int Unk009;

	[FieldOffset(68)]
	[ElementType(typeof(int))]
	public TArray PassiveType;

	[FieldOffset(84)]
	public int Unk011;

}
