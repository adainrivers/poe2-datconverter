namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AncestralTrialTribeOpinions
{
	[FieldOffset(0)]
	[ReferenceTable("AncestralTrialTribes")]
	public TableReference SourceTribe;

	[FieldOffset(16)]
	[ReferenceTable("AncestralTrialTribes")]
	public TableReference TargetTribe;

	[FieldOffset(32)]
	[ReferenceTable("AncestralTrialOpinionTypes")]
	[EnumName("AncestralTrialOpinionTypes")]
	public TEnum Opinion;

}
