namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialBossOptions
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	public StringReference DefaultIcon;

	[FieldOffset(16)]
	public StringReference HoverIcon;

	[FieldOffset(24)]
	public StringReference HighlightIcon;

	[FieldOffset(32)]
	public StringReference EmptyIcon;

	[FieldOffset(40)]
	[ReferenceTable("ClientStrings")]
	public TableReference Description;

	[FieldOffset(56)]
	[ReferenceTable("ClientStrings")]
	public TableReference DescriptionActive;

	[FieldOffset(72)]
	public StringReference ProgressTracker;

	[FieldOffset(80)]
	public StringReference ProgressTrackerFill;

	[FieldOffset(88)]
	public StringReference Name;

	[FieldOffset(96)]
	public StringReference MapDeviceTrackerFill;

}
