using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestStaticRewards
{
	[FieldOffset(0)]
	[ReferenceTable("QuestFlags")]
	public TableReference QuestFlag;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TableReference))]
	public ArrayReference StatsKeys;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference StatValues;

	[FieldOffset(56)]
	[ReferenceTable("Quest")]
	public TableReference QuestKey;

	[FieldOffset(72)]
	public int Unk005;

	[FieldOffset(76)]
	[ReferenceTable("ClientStrings")]
	public TableReference ClientStringsKey;

	[FieldOffset(92)]
	public int Unk007;

    [FieldOffset(96)]
    public TBool Unk008;

    //[FieldOffset(92)]
    //[ElementType(typeof(int))]
    //public TArray StatValuesHardmode;

    //[FieldOffset(108)]
    //[ReferenceTable("ClientStrings")]
    //public TableReference ClientStringHardmode;

    //[FieldOffset(124)]
    //public TableReference Unk010;

}
