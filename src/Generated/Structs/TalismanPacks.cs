using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TalismanPacks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacksKeys;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(48)]
	public TRef Unk005;

	[FieldOffset(64)]
	public int Unk006;

	[FieldOffset(68)]
	public int Unk007;

	[FieldOffset(72)]
	public int Unk008;

	[FieldOffset(76)]
	[ReferenceTable("MonsterPacks")]
	public TRef MonsterPacksKey;

}
