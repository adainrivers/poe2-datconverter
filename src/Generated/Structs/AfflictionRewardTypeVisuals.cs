using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AfflictionRewardTypeVisuals
{
	[FieldOffset(0)]
	[ReferenceTable("AfflictionRewardTypes")]
	[EnumName("AfflictionRewardTypes")]
	public TEnum AfflictionRewardTypes;

	[FieldOffset(4)]
	public TString Id;

	[FieldOffset(12)]
	public TString Name;

}
