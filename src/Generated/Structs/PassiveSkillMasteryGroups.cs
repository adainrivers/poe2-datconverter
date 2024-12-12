namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillMasteryGroups
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ReferenceTable("PassiveSkillMasteryEffects")]
	[ElementType(typeof(TableReference))]
	public ArrayReference MasteryEffects;

	[FieldOffset(24)]
	public StringReference InactiveIcon;

	[FieldOffset(32)]
	public StringReference ActiveIcon;

	[FieldOffset(40)]
	public StringReference ActiveEffectImage;

	[FieldOffset(48)]
	public TBool Unk005;

	[FieldOffset(49)]
	[ReferenceTable("SoundEffects")]
	public TableReference SoundEffect;

	[FieldOffset(65)]
	[ReferenceTable("Stats")]
	public TableReference MasteryCountStat;

}
