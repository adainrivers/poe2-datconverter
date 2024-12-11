using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapeFactions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Environments")]
	public TRef Unk001;

	[FieldOffset(24)]
	[ReferenceTable("Environments")]
	public TRef Unk002;

	[FieldOffset(40)]
	[ReferenceTable("Environments")]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	public int Unk004;

	[FieldOffset(60)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray Unk005;

	[FieldOffset(76)]
	public TString Unk006;

	[FieldOffset(84)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Boss;

}
