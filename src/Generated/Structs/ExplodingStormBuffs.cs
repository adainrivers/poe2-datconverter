using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExplodingStormBuffs
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey1;

	[FieldOffset(24)]
	public TRef Unk002;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray StatValues;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(76)]
	public int Unk006;

	[FieldOffset(80)]
	public int Unk007;

	[FieldOffset(84)]
	public int Unk008;

	[FieldOffset(88)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Friendly_MonsterVarietiesKey;

	[FieldOffset(104)]
	[ReferenceTable("MiscObjects")]
	public TRef MiscObjectsKey;

	[FieldOffset(120)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey;

	[FieldOffset(136)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisualsKey;

	[FieldOffset(152)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Enemy_MonsterVarietiesKey;

	[FieldOffset(168)]
	public int Unk014;

	[FieldOffset(172)]
	public int Unk015;

	[FieldOffset(176)]
	public int Unk016;

	[FieldOffset(180)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey2;

	[FieldOffset(196)]
	public TBool IsOnlySpawningNearPlayer;

}
