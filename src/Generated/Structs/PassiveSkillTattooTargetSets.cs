using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTattooTargetSets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Set;

	[FieldOffset(24)]
	public TString Name;

	[FieldOffset(32)]
	public TString Qualifier;

}
