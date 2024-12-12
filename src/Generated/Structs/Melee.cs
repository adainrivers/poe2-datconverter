namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Melee
{
	[FieldOffset(0)]
	[ReferenceTable("ActiveSkills")]
	public TableReference ActiveSkill;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	[ReferenceTable("MiscAnimated")]
	public TableReference MiscAnimated;

	[FieldOffset(36)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey1;

	[FieldOffset(52)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey2;

	[FieldOffset(68)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey3;

	[FieldOffset(84)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey4;

	[FieldOffset(100)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey5;

	[FieldOffset(116)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey6;

	[FieldOffset(132)]
	[ReferenceTable("MeleeTrails")]
	public TableReference MeleeTrailsKey7;

	[FieldOffset(148)]
	public TBool Unk010;

	[FieldOffset(149)]
	public StringReference SurgeEffect_EPKFile;

	[FieldOffset(157)]
	public StringReference Unk012;

	[FieldOffset(165)]
	public StringReference Unk013;

}
