using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CorpseTypeTags
{
	[FieldOffset(0)]
	[ReferenceTable("Tags")]
	public TRef Tag;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	[ReferenceTable("BuffDefinitions")]
	public TRef RavenousBuff;

	[FieldOffset(40)]
	public TString Icon;

	[FieldOffset(48)]
	public int Unk004;

}
