namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EntityInfobarStyle
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference FrameLeft;

	[FieldOffset(16)]
	public StringReference FrameMiddle;

	[FieldOffset(24)]
	public StringReference FrameRepeat;

	[FieldOffset(32)]
	public StringReference FrameRight;

	[FieldOffset(40)]
	public StringReference EntityLeft;

	[FieldOffset(48)]
	public StringReference EntityMiddle;

	[FieldOffset(56)]
	public StringReference EntityRepeat;

	[FieldOffset(64)]
	public StringReference EntityRight;

	[FieldOffset(72)]
	public StringReference EntityStats;

	[FieldOffset(80)]
	public StringReference EntityStatsSmall;

	[FieldOffset(88)]
	public int Unk011;

	[FieldOffset(92)]
	public int Unk012;

	[FieldOffset(96)]
	public StringReference LifeBar;

	[FieldOffset(104)]
	public StringReference LifeBarLeft;

	[FieldOffset(112)]
	public StringReference LifeBarMiddle;

	[FieldOffset(120)]
	public StringReference LifeBarRepeat;

	[FieldOffset(128)]
	public StringReference LifeBarRight;

}
