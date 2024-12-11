using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistChokepointFormation
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(36)]
	[ReferenceTable("GrantedEffects")]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(52)]
	[ReferenceTable("GrantedEffects")]
	public TRef Unk004;

	[FieldOffset(68)]
	public int Unk005;

	[FieldOffset(72)]
	public TBool Unk006;

	[FieldOffset(73)]
	public int Unk007;

	[FieldOffset(77)]
	public int Unk008;

	[FieldOffset(81)]
	public int Unk009;

	[FieldOffset(85)]
	public int Unk010;

}
