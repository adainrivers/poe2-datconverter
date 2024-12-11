using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryGenus
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("BestiaryGroups")]
	public TRef BestiaryGroupsKey;

	[FieldOffset(32)]
	public TString Name2;

	[FieldOffset(40)]
	public TString Icon;

}
