using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct StashType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("StashId")]
	[EnumName("StashId")]
	public TEnum StashId;

	[FieldOffset(12)]
	public TString Id2;

	[FieldOffset(20)]
	public int Unk003;

	[FieldOffset(24)]
	public int Unk004;

	[FieldOffset(28)]
	public int Unk005;

	[FieldOffset(32)]
	public TString Icon;

}
