namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualEffect
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference DaggerEPKFile;

	[FieldOffset(16)]
	public StringReference BowEPKFile;

	[FieldOffset(24)]
	public StringReference OneHandedMaceEPKFile;

	[FieldOffset(32)]
	public StringReference OneHandedSwordEPKFile;

	[FieldOffset(40)]
	public StringReference Unk005;

	[FieldOffset(48)]
	public StringReference TwoHandedSwordEPKFile;

	[FieldOffset(56)]
	public StringReference TwoHandedStaffEPKFile;

	[FieldOffset(64)]
	public short HASH16;

	[FieldOffset(66)]
	public StringReference TwoHandedMaceEPKFile;

	[FieldOffset(74)]
	public StringReference OneHandedAxeEPKFile;

	[FieldOffset(82)]
	public StringReference TwoHandedAxeEPKFile;

	[FieldOffset(90)]
	public StringReference ClawEPKFile;

	[FieldOffset(98)]
	public StringReference PETFile;

	[FieldOffset(106)]
	[ElementType(typeof(StringReference))]
	public ArrayReference Shield;

	[FieldOffset(122)]
	public TBool Unk015;

}
