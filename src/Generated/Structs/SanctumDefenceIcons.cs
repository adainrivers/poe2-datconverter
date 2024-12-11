using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumDefenceIcons
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(24)]
	public TString DefenceIcon;

	[FieldOffset(32)]
	public TString DefenceBrokenIcon;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TRef BrokenStat;

	[FieldOffset(56)]
	public TString Description;

}
