namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GemEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffect;

    [FieldOffset(32)] public StringReference SupportText;
    [FieldOffset(40)] public StringReference SupportName;

    [FieldOffset(48)]
    [ElementType(typeof(TableReference))]
    [ReferenceTable("GemTags")]
    public ArrayReference GemTags;

    [FieldOffset(64)]
    public TableReference Unk064;

    [FieldOffset(80)]
    public int Unk080;

    [FieldOffset(84)]
    [ElementType(typeof(TableReference))]
    public ArrayReference Unk084;

    [FieldOffset(100)]
    [ElementType(typeof(TableReference))]
    public ArrayReference Unk100;



    //   [FieldOffset(32)]
    //[ReferenceTable("GrantedEffects")]
    //public TableReference GrantedEffectHardmode;

    //[FieldOffset(48)]
    //[ReferenceTable("GrantedEffects")]
    //public TableReference GrantedEffect2;

    //[FieldOffset(64)]
    //[ReferenceTable("GrantedEffects")]
    //public TableReference GrantedEffect2Hardmode;

    //[FieldOffset(80)]
    //public StringReference SupportText;

    //[FieldOffset(88)]
    //public StringReference SupportName;

    //[FieldOffset(96)]
    //[ReferenceTable("GemTags")]
    //[ElementType(typeof(TableReference))]
    //public ArrayReference GemTags;

    //[FieldOffset(112)]
    //[ReferenceTable("Mods")]
    //public TableReference Consumed_ModsKey;

    //[FieldOffset(128)]
    //public int ItemColor;

}
