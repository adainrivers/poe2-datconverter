namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalUpgrades
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Name;

	[FieldOffset(16)]
	public StringReference Description;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TableReference))]
	public ArrayReference ModsKey;

	[FieldOffset(40)]
	public StringReference ArtFile;

	[FieldOffset(48)]
	public int BetrayalUpgradeSlotsKey;

	[FieldOffset(52)]
	[ElementType(typeof(int))]
	public ArrayReference Unk006;

	[FieldOffset(68)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey0;

	[FieldOffset(84)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey1;

	[FieldOffset(100)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffectsKey;

	[FieldOffset(116)]
	public int Unk010;

	[FieldOffset(120)]
	[ReferenceTable("ItemClasses")]
	public TableReference ItemClassesKey;

}
