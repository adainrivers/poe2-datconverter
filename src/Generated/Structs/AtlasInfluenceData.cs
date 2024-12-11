using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasInfluenceData
{
	[FieldOffset(0)]
	[ReferenceTable("AtlasInfluenceOutcomes")]
	public TRef InfluencePack;

	[FieldOffset(16)]
	[ReferenceTable("MonsterPacks")]
	[ElementType(typeof(TRef))]
	public TArray MonsterPacks;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(64)]
	public int Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public int Unk006;

	[FieldOffset(76)]
	public int Unk007;

	[FieldOffset(80)]
	[ElementType(typeof(int))]
	public TArray Unk008;

	[FieldOffset(96)]
	public int Unk009;

	[FieldOffset(100)]
	public int Unk010;

	[FieldOffset(104)]
	public TRef Unk011;

	[FieldOffset(120)]
	public int Unk012;

	[FieldOffset(124)]
	public int Unk013;

	[FieldOffset(128)]
	public int Unk014;

	[FieldOffset(132)]
	public int Unk015;

	[FieldOffset(136)]
	public bool Unk016;

	[FieldOffset(137)]
	public bool Unk017;

	[FieldOffset(138)]
	public bool Unk018;

	[FieldOffset(139)]
	public bool Unk019;

}
