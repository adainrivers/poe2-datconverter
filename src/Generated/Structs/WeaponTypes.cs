namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct WeaponTypes
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TableReference BaseItemTypesKey;

	[FieldOffset(16)]
	public int Critical;

	[FieldOffset(20)]
	public int Unk02;

	[FieldOffset(24)]
	public int Unk03;

	[FieldOffset(28)]
	public int Unk04;

	[FieldOffset(32)]
	public int RangeMax;

	[FieldOffset(36)]
	public int Speed;

    [FieldOffset(40)]
    public int DamageMin;

    [FieldOffset(44)]
    public int DamageMax;

    [FieldOffset(48)]
    public int Unk009;

    [FieldOffset(52)]
    public int ReloadTime;

}
