using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MonsterPackEntries
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	public TRef MonsterPacksKey;

	[FieldOffset(24)]
	public bool Unk002;

	[FieldOffset(25)]
	public int Unk003;

	[FieldOffset(29)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(45)]
	[ReferenceTable("MonsterPackEntries")]
	public TRef Unk005;

}
