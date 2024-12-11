using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BuffTemplates
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Buff_StatValues;

	[FieldOffset(40)]
	public int AuraRadius;

	[FieldOffset(44)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(60)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(76)]
	[ReferenceTable("BuffVisuals")]
	public TRef BuffVisualsKey;

	[FieldOffset(92)]
	public float Unk007;

	[FieldOffset(96)]
	public TBool Unk008;

	[FieldOffset(97)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKey;

	[FieldOffset(113)]
	public int Unk010;

	[FieldOffset(117)]
	public int Unk011;

	[FieldOffset(121)]
	public TBool Unk012;

	[FieldOffset(122)]
	[ReferenceTable("Stats")]
	public TRef Unk013;

}
