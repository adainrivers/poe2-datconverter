namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CharacterCreationDialogue
{
    [FieldOffset(0)]
    [ReferenceTable("Characters")]
    public TableReference Character;

    [FieldOffset(16)]
    [ReferenceTable("NpcTextAudio")]
    public TableReference IntroDialogue;

    [FieldOffset(32)]
    public TableReference Unk03;

    [FieldOffset(48)]
    [ReferenceTable("NpcTextAudio")]
    public TableReference EscapeDialogue;
}