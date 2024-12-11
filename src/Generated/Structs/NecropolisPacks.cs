using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct NecropolisPacks
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString Icon;

	[FieldOffset(24)]
	public TString Description;

	[FieldOffset(32)]
	public TString PackLeader1;

	[FieldOffset(40)]
	public TString PackLeader2;

	[FieldOffset(48)]
	[ReferenceTable("Mods")]
	public TRef Mod;

}
