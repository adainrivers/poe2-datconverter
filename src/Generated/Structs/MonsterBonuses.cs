using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterBonuses
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(72)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(88)]
	public bool Unk006;

	[FieldOffset(89)]
	public bool Unk007;

	[FieldOffset(90)]
	public bool Unk008;

	[FieldOffset(91)]
	public bool Unk009;

}
