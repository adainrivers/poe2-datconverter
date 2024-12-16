namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ActiveSkillRequirements
{
    [FieldOffset(0)]
    public TableReference SomeRef01;

    [FieldOffset(16)]
    public TableReference SomeRef02;

    [FieldOffset(32)]
    public int SomeInt01;

    [FieldOffset(36)]
    public TBool SomeBool01;

    [FieldOffset(37)]
    public int SomeInt02;
}
