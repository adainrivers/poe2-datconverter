namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Projectiles
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	[ElementType(typeof(StringReference))]
	public ArrayReference AOFiles;

	[FieldOffset(24)]
	[ElementType(typeof(StringReference))]
	public ArrayReference LoopAnimationIds;

	[FieldOffset(40)]
	[ElementType(typeof(StringReference))]
	public ArrayReference ImpactAnimationIds;

	[FieldOffset(56)]
	public int ProjectileSpeed;

	[FieldOffset(60)]
	public TBool Unk005;

	[FieldOffset(61)]
	public int Unk006;

	[FieldOffset(65)]
	public TBool Unk007;

	[FieldOffset(66)]
	public TBool Unk008;

	[FieldOffset(67)]
	public StringReference InheritsFrom;

	[FieldOffset(75)]
	public int Unk010;

	[FieldOffset(79)]
	public TableReference Unk011;

	[FieldOffset(95)]
	public int Unk012;

	[FieldOffset(99)]
	public TBool Unk013;

	[FieldOffset(100)]
	public TBool Unk014;

	[FieldOffset(101)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Stuck_AOFile;

	[FieldOffset(117)]
	public StringReference Bounce_AOFile;

	[FieldOffset(125)]
	public int Unk017;

	[FieldOffset(129)]
	public int Unk018;

	[FieldOffset(133)]
	public int Unk019;

	[FieldOffset(137)]
	public int Unk020;

	[FieldOffset(141)]
	public TableReference Unk021;

	[FieldOffset(157)]
	public TableReference Unk022;

	[FieldOffset(173)]
	public int Unk023;

	[FieldOffset(177)]
	public int Unk024;

	[FieldOffset(181)]
	public int Unk025;

	[FieldOffset(185)]
	public int Unk026;

	[FieldOffset(189)]
	public int Unk027;

	[FieldOffset(193)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Unk028;

	[FieldOffset(209)]
	public TBool Unk029;

	[FieldOffset(210)]
	[ElementType(typeof(int))]
	public ArrayReference Unk030;

	[FieldOffset(226)]
	[ReferenceTable("Projectiles")]
	public TableReference Unk031;

}
