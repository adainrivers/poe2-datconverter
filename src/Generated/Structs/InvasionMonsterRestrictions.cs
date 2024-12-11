using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct InvasionMonsterRestrictions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(24)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk003;

}
