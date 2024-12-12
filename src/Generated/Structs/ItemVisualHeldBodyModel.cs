namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemVisualHeldBodyModel
{
	[FieldOffset(0)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentity;

	[FieldOffset(16)]
	public StringReference MarauderAnimatedObject;

	[FieldOffset(24)]
	public StringReference RangerAnimatedObject;

	[FieldOffset(32)]
	public StringReference WitchAnimatedObject;

	[FieldOffset(40)]
	public StringReference DuelistAnimatedObject;

	[FieldOffset(48)]
	public StringReference TemplarAnimatedObject;

	[FieldOffset(56)]
	public StringReference ShadowAnimatedObject;

	[FieldOffset(64)]
	public StringReference ScionAnimatedObject;

	[FieldOffset(72)]
	public StringReference MarauderBone;

	[FieldOffset(80)]
	public StringReference RangerBone;

	[FieldOffset(88)]
	public StringReference WitchBone;

	[FieldOffset(96)]
	public StringReference DuelistBone;

	[FieldOffset(104)]
	public StringReference TemplarBone;

	[FieldOffset(112)]
	public StringReference ShadowBone;

	[FieldOffset(120)]
	public StringReference ScionBone;

}
