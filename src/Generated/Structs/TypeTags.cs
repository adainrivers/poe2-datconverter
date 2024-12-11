using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TypeTags
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	public TRef Tag;

	[FieldOffset(24)]
	public TString Name;

	[FieldOffset(32)]
	public TString Icon;

	[FieldOffset(40)]
	[ReferenceTable("Stats")]
	public TRef Unk004;

}
