using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemTags
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Tag;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	public TRef Stat1;

	[FieldOffset(32)]
	[ReferenceTable("Stats")]
	public TRef Stat2;

	[FieldOffset(48)]
	[ReferenceTable("Stats")]
	public TRef Stat3;

	[FieldOffset(64)]
	[ReferenceTable("Stats")]
	public TRef Stat4;

}
