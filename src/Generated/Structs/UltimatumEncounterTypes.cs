namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumEncounterTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference ProgressBarText;

	[FieldOffset(24)]
	public TBool Unk003;

	[FieldOffset(25)]
	public TBool Unk004;

	[FieldOffset(26)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference NormalAchievements;

	[FieldOffset(42)]
	[ReferenceTable("AchievementItems")]
	public TableReference InscribedAchievement;

	[FieldOffset(58)]
	public TableReference Unk007;

}
