namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GrantedEffects
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool IsSupport;

	[FieldOffset(9)]
	[ReferenceTable("ActiveSkillType")]
	[ElementType(typeof(TableReference))]
	public ArrayReference AllowedActiveSkillTypes;

    [FieldOffset(25)]
	public long Unk025;

    [FieldOffset(33)]
    public long Unk033;

    [FieldOffset(41)]
    public long Unk041;

    [FieldOffset(49)]
    public long Unk049;

    [FieldOffset(57)]
    public long Unk057;

    [FieldOffset(65)]
    public TBool Unk065;

    [FieldOffset(66)]
    public int Unk066;

    [FieldOffset(70)]
    public TBool Unk070;

    [FieldOffset(71)]
    public int Unk071;

    [FieldOffset(75)]
	public int Unk075;


    [FieldOffset(79)]
    [ReferenceTable("ActiveSkills")]
    public TableReference ActiveSkill;

    [FieldOffset(113)]
	public TableReference Unk113;

	[FieldOffset(129)]
	public TableReference Unk129;


	[FieldOffset(145)]
    public TBool Unk145;

    [FieldOffset(146)]
    public long Unk146;

    [FieldOffset(154)]
    public long Unk154;

    [FieldOffset(162)] public StringReference Unk162;

 //   [FieldOffset(170)]
	//[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.U1)]
 //   public byte[] Unk170;


    [FieldOffset(184)]
	[ReferenceTable("GrantedEffectStatSets")]
	public TableReference DefaultStatSet;

    [FieldOffset(200)]
    [ReferenceTable("GrantedEffectStatSets")]
	[ElementType(typeof(TableReference))]
    public ArrayReference AdditionalStatSets;


	[FieldOffset(224)]
	[ElementType(typeof(long))]
    public ArrayReference Unk216;

}
