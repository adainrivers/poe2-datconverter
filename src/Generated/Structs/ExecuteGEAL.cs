using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExecuteGEAL
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	[ReferenceTable("MiscAnimated")]
	[ElementType(typeof(TRef))]
	public TArray MiscAnimated;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public int Unk006;

	[FieldOffset(40)]
	public int Unk007;

	[FieldOffset(44)]
	public TBool Unk008;

	[FieldOffset(45)]
	public int Unk009;

	[FieldOffset(49)]
	public int Unk010;

	[FieldOffset(53)]
	public int Unk011;

	[FieldOffset(57)]
	public TBool Unk012;

	[FieldOffset(58)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(74)]
	public TBool Unk014;

	[FieldOffset(75)]
	public int Unk015;

	[FieldOffset(79)]
	public TRef Unk016;

	[FieldOffset(95)]
	public TBool Unk017;

	[FieldOffset(96)]
	public TString Script;

	[FieldOffset(104)]
	public TBool Unk019;

	[FieldOffset(105)]
	public int Unk020;

	[FieldOffset(109)]
	public TBool Unk021;

	[FieldOffset(110)]
	public int Unk022;

	[FieldOffset(114)]
	public int Unk023;

	[FieldOffset(118)]
	public TBool Unk024;

	[FieldOffset(119)]
	public int Unk025;

	[FieldOffset(123)]
	[ElementType(typeof(TString))]
	public TArray MetadataIDs;

	[FieldOffset(139)]
	public TString ScriptCommand;

	[FieldOffset(147)]
	[ElementType(typeof(int))]
	public TArray Unk028;

	[FieldOffset(163)]
	[ElementType(typeof(int))]
	public TArray Unk029;

	[FieldOffset(179)]
	public int Unk030;

	[FieldOffset(183)]
	public TBool Unk031;

	[FieldOffset(184)]
	[ElementType(typeof(int))]
	public TArray Unk032;

	[FieldOffset(200)]
	public TBool Unk033;

	[FieldOffset(201)]
	public int Unk034;

	[FieldOffset(205)]
	public TBool Unk035;

	[FieldOffset(206)]
	public int Unk036;

	[FieldOffset(210)]
	public TBool Unk037;

	[FieldOffset(211)]
	public int Unk038;

	[FieldOffset(215)]
	public int Unk039;

	[FieldOffset(219)]
	public int Unk040;

}
