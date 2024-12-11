using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ScarabTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	public TRef Tag;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TRef DisableDrops;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TRef MoreLikely;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TRef Count;

}
