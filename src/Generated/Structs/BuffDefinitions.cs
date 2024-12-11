using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffDefinitions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	public bool Invisible;

	[FieldOffset(17)]
	public bool Removable;

	[FieldOffset(18)]
	public TString Name;

	[FieldOffset(26)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(42)]
	public bool Unk006;

	[FieldOffset(43)]
	public int Unk007;

	[FieldOffset(47)]
	public bool Unk008;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TRef Maximum_StatsKey;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TRef Current_StatsKey;

	[FieldOffset(80)]
	public bool Unk011;

	[FieldOffset(81)]
	public int Unk012;

	[FieldOffset(85)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisualsKey;

	[FieldOffset(101)]
	public bool Unk014;

	[FieldOffset(102)]
	public bool Unk015;

	[FieldOffset(103)]
	public int BuffCategory;

	[FieldOffset(107)]
	public bool Unk017;

	[FieldOffset(108)]
	public bool Unk018;

	[FieldOffset(109)]
	public bool Unk019;

	[FieldOffset(110)]
	public bool Unk020;

	[FieldOffset(111)]
	public int BuffLimit;

	[FieldOffset(115)]
	public bool Unk022;

	[FieldOffset(116)]
	public TString Id2;

	[FieldOffset(124)]
	public bool IsRecovery;

	[FieldOffset(125)]
	public bool Unk025;

	[FieldOffset(126)]
	public TRef Unk026;

	[FieldOffset(142)]
	public bool Unk027;

	[FieldOffset(143)]
	public int Unk028;

	[FieldOffset(147)]
	public bool Unk029;

	[FieldOffset(148)]
	public bool Unk030;

	[FieldOffset(149)]
	public int Unk031;

	[FieldOffset(153)]
	[ElementType(typeof(int))]
	public TArray Unk032;

	[FieldOffset(169)]
	public bool Unk033;

	[FieldOffset(170)]
	public bool Unk034;

	[FieldOffset(171)]
	[ElementType(typeof(TRef))]
	public TArray Unk035;

	[FieldOffset(187)]
	public bool Unk036;

	[FieldOffset(188)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk037;

	[FieldOffset(204)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray BinaryStats;

	[FieldOffset(220)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk039;

	[FieldOffset(236)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk040;

	[FieldOffset(252)]
	public bool Unk041;

	[FieldOffset(253)]
	public bool Unk042;

	[FieldOffset(254)]
	public bool Unk043;

	[FieldOffset(255)]
	public bool Unk044;

	[FieldOffset(256)]
	public bool Unk045;

	[FieldOffset(257)]
	[ReferenceTable("Stats")]
	public TRef Unk046;

	[FieldOffset(273)]
	[ElementType(typeof(int))]
	public TArray Unk047;

	[FieldOffset(289)]
	public TString Unk048;

	[FieldOffset(297)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Unk049;

	[FieldOffset(313)]
	public bool Unk050;

}
