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

	[FieldOffset(32)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffectHardmode;

	[FieldOffset(48)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffect2;

	[FieldOffset(64)]
	[ReferenceTable("GrantedEffects")]
	public TableReference GrantedEffect2Hardmode;

	[FieldOffset(80)]
	public StringReference SupportText;

	[FieldOffset(88)]
	public StringReference SupportName;

	[FieldOffset(96)]
	[ReferenceTable("GemTags")]
	[ElementType(typeof(TableReference))]
	public ArrayReference GemTags;

	[FieldOffset(112)]
	[ReferenceTable("Mods")]
	public TableReference Consumed_ModsKey;

	[FieldOffset(128)]
	public int ItemColor;

}
