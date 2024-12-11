using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialTribeOpinions
{
	[FieldOffset(0)]
	[ReferenceTable("AncestralTrialTribes")]
	public TRef SourceTribe;

	[FieldOffset(16)]
	[ReferenceTable("AncestralTrialTribes")]
	public TRef TargetTribe;

	[FieldOffset(32)]
	[ReferenceTable("AncestralTrialOpinionTypes")]
	[EnumName("AncestralTrialOpinionTypes")]
	public TEnum Opinion;

}
