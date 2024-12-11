using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NPCFollowerVariations
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(16)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey0;

	[FieldOffset(32)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey1;

	[FieldOffset(48)]
	public bool Unk003;

	[FieldOffset(49)]
	public bool Unk004;

	[FieldOffset(50)]
	public int Unk005;

	[FieldOffset(54)]
	public int Unk006;

	[FieldOffset(58)]
	public int Unk007;

	[FieldOffset(62)]
	public int Unk008;

	[FieldOffset(66)]
	public bool Unk009;

	[FieldOffset(67)]
	public bool Unk010;

	[FieldOffset(68)]
	[ElementType(typeof(int))]
	public TArray Unk011;

	[FieldOffset(84)]
	[ElementType(typeof(int))]
	public TArray Unk012;

	[FieldOffset(100)]
	public int Unk013;

	[FieldOffset(104)]
	public bool Unk014;

	[FieldOffset(105)]
	public bool Unk015;

	[FieldOffset(106)]
	public int Unk016;

}
