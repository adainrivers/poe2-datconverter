using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BreachElement
{
	[FieldOffset(0)]
	public TString Element;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseBreachstone;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TRef BossMapMod;

	[FieldOffset(56)]
	[ReferenceTable("Stats")]
	public TRef DuplicateBoss;

}
