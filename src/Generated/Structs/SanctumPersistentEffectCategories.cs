namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SanctumPersistentEffectCategories
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Frame;

	[FieldOffset(16)]
	public StringReference Popup;

	[FieldOffset(24)]
	public StringReference Glow;

	[FieldOffset(32)]
	public TBool Curse;

	[FieldOffset(33)]
	public TBool Boon;

	[FieldOffset(34)]
	public StringReference Icon;

	[FieldOffset(42)]
	public StringReference Name;

	[FieldOffset(50)]
	public TBool Deferral;

}
