namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ExpeditionAreas
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TableReference Area;

	[FieldOffset(16)]
	public int PosX;

	[FieldOffset(20)]
	public int PosY;

	[FieldOffset(24)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference Tags;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public ArrayReference Unk004;

	[FieldOffset(56)]
	public TBool Unk005;

	[FieldOffset(57)]
	[ReferenceTable("NPCTextAudio")]
	public TableReference TextAudio;

	[FieldOffset(73)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TableReference))]
	public ArrayReference CompletionAchievements;

}
