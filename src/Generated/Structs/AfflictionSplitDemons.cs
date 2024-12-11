using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionSplitDemons
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(20)]
	[ReferenceTable("AfflictionRandomModCategories")]
	public TRef AfflictionRandomModCategoriesKey;

}
