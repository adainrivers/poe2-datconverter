using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GenericLeagueRewardTypeVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("GenericLeagueRewardTypes")]
	public TRef Type;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public float Unk003;

	[FieldOffset(52)]
	public TString Icon;

	[FieldOffset(60)]
	public TString Name;

}
