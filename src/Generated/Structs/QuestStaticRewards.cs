using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestStaticRewards
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TRef QuestFlag;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(52)]
	[ReferenceTable("Quest")]
	public TRef QuestKey;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStringsKey;

	[FieldOffset(88)]
	public int Unk007;

	[FieldOffset(92)]
	[ElementType(typeof(int))]
	public TArray StatValuesHardmode;

	[FieldOffset(108)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStringHardmode;

	[FieldOffset(124)]
	public TRef Unk010;

}
