using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ModEquivalencies
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Mods")]
	public TRef ModsKey0;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	public TRef ModsKey1;

	[FieldOffset(40)]
	[ReferenceTable("Mods")]
	public TRef ModsKey2;

	[FieldOffset(56)]
	public TBool Unk004;

}
