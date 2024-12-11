using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SummonedSpecificMonsters
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	public TRef Unk003;

	[FieldOffset(40)]
	public bool Unk004;

	[FieldOffset(41)]
	public bool Unk005;

	[FieldOffset(42)]
	public int Unk006;

	[FieldOffset(46)]
	public int Unk007;

	[FieldOffset(50)]
	public bool Unk008;

	[FieldOffset(51)]
	public TRef Unk009;

	[FieldOffset(67)]
	public TRef Unk010;

	[FieldOffset(83)]
	public int Unk011;

	[FieldOffset(87)]
	public bool Unk012;

	[FieldOffset(88)]
	public int Unk013;

	[FieldOffset(92)]
	public TString Unk014;

	[FieldOffset(100)]
	public bool Unk015;

	[FieldOffset(101)]
	public bool Unk016;

	[FieldOffset(102)]
	public int Unk017;

}
