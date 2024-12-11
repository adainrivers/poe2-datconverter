using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapStashSpecialTypeEntries
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("BaseItemTypes")]
	public TRef MapItem;

	[FieldOffset(28)]
	public TString Name;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public bool IsShaperGuardian;

	[FieldOffset(41)]
	public bool IsElderGuardian;

	[FieldOffset(42)]
	public TRef Unk007;

	[FieldOffset(58)]
	public TRef Unk008;

	[FieldOffset(74)]
	public TRef Unk009;

}
