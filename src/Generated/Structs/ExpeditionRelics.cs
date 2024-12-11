using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionRelics
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("Tags")]
	public TRef ItemTag;

	[FieldOffset(32)]
	public TString AOFile;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	public int MaxLevel;

}
