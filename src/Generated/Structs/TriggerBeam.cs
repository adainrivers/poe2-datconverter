using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TriggerBeam
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ReferenceTable("MiscBeams")]
	[ElementType(typeof(TRef))]
	public TArray Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MiscBeams")]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(52)]
	public bool Unk004;

	[FieldOffset(53)]
	public int Unk005;

	[FieldOffset(57)]
	public int Unk006;

	[FieldOffset(61)]
	public int Unk007;

	[FieldOffset(65)]
	public int Unk008;

	[FieldOffset(69)]
	public bool Unk009;

	[FieldOffset(70)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(86)]
	public bool Unk011;

	[FieldOffset(87)]
	public int Unk012;

	[FieldOffset(91)]
	public bool Unk013;

}
