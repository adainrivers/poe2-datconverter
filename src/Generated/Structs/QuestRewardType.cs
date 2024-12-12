using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct QuestRewardType
{
    [FieldOffset(0)]
    public StringReference Id;

    [FieldOffset(8)] 
    public StringReference Icon;

    [FieldOffset(16)]
    public StringReference Name;

    [FieldOffset(24)]
    public StringReference Description;

    [FieldOffset(32)]
    public TableReference SomeRef;
}