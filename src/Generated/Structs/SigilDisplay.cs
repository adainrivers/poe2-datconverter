using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SigilDisplay
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Stats")]
	public TRef Active_StatsKey;

	[FieldOffset(24)]
	[ReferenceTable("Stats")]
	public TRef Inactive_StatsKey;

	[FieldOffset(40)]
	public TString DDSFile;

	[FieldOffset(48)]
	public TString Inactive_ArtFile;

	[FieldOffset(56)]
	public TString Active_ArtFile;

	[FieldOffset(64)]
	public TString Frame_ArtFile;

}
