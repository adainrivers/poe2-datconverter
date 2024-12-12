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

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(56)]
	[ReferenceTable("Quest")]
	public TRef QuestKey;

	[FieldOffset(72)]
	public int Unk005;

	[FieldOffset(76)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStringsKey;

	[FieldOffset(92)]
	public int Unk007;

    [FieldOffset(96)]
    public TBool Unk008;

    //[FieldOffset(92)]
    //[ElementType(typeof(int))]
    //public TArray StatValuesHardmode;

    //[FieldOffset(108)]
    //[ReferenceTable("ClientStrings")]
    //public TRef ClientStringHardmode;

    //[FieldOffset(124)]
    //public TRef Unk010;

}
