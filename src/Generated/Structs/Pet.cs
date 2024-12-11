using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Pet
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(24)]
	public int HASH16;

	[FieldOffset(28)]
	public int HASH32;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public bool Unk005;

	[FieldOffset(37)]
	public bool Unk006;

	[FieldOffset(38)]
	[ElementType(typeof(int))]
	public TArray Unk007;

	[FieldOffset(54)]
	public TRef Unk008;

	[FieldOffset(70)]
	[ReferenceTable("GrantedEffectsPerLevel")]
	[ElementType(typeof(TRef))]
	public TArray Skills;

	[FieldOffset(86)]
	public int Unk010;

	[FieldOffset(90)]
	public bool Unk011;

	[FieldOffset(91)]
	public TRef Unk012;

	[FieldOffset(107)]
	public bool Unk013;

}
