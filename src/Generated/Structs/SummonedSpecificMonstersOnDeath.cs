using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificMonstersOnDeath
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public TRef Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public bool Unk005;

}
