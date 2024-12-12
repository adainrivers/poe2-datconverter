namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PassiveSkillTreeUIArt
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference GroupBackgroundSmall;

	[FieldOffset(16)]
	public StringReference GroupBackgroundMedium;

	[FieldOffset(24)]
	public StringReference GroupBackgroundLarge;

	[FieldOffset(32)]
	public TBool Unk004;

	[FieldOffset(33)]
	public StringReference PassiveFrameNormal;

	[FieldOffset(41)]
	public StringReference NotableFrameNormal;

	[FieldOffset(49)]
	public StringReference KeystoneFrameNormal;

	[FieldOffset(57)]
	public StringReference PassiveFrameActive;

	[FieldOffset(65)]
	public StringReference NotableFrameActive;

	[FieldOffset(73)]
	public StringReference KeystoneFrameActive;

	[FieldOffset(81)]
	public StringReference PassiveFrameCanAllocate;

	[FieldOffset(89)]
	public StringReference NotableFrameCanAllocate;

	[FieldOffset(97)]
	public StringReference KeystoneCanAllocate;

	[FieldOffset(105)]
	public StringReference Ornament;

	[FieldOffset(113)]
	public StringReference GroupBackgroundSmallBlank;

	[FieldOffset(121)]
	public StringReference GroupBackgroundMediumBlank;

	[FieldOffset(129)]
	public StringReference GroupBackgroundLargeBlank;

}
