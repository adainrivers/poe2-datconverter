namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SkillCraftingData
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
    [ReferenceTable("Characters")]
    public TableReference CharacterKey;

    // 'art\textures\interface\2d\'
    [FieldOffset(24)]
	public StringReference Background;

    // 'art\textures\interface\2d\'
    [FieldOffset(32)]
    public StringReference Icon;

    // 'art\textures\interface\2d\'
    [FieldOffset(40)]
    public StringReference LargeIcon;

    [FieldOffset(48)]
    public StringReference Text;

}
