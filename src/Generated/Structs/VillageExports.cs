using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VillageExports
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public int Unk002;

	[FieldOffset(20)]
	public TString Icon;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	public int Unk005;

	[FieldOffset(36)]
	public TString Icon2;

	[FieldOffset(44)]
	public TString Name2;

	[FieldOffset(52)]
	public TString IconCombined;

	[FieldOffset(60)]
	[ReferenceTable("VillageExports")]
	public TRef Result;

	[FieldOffset(68)]
	public int Unk010;

}
