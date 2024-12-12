namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueStashTypes
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public int Order;

	[FieldOffset(12)]
	public int Width;

	[FieldOffset(16)]
	public int Height;

	[FieldOffset(20)]
	public int TotalCount;

	[FieldOffset(24)]
	public int Unk005;

	[FieldOffset(28)]
	public StringReference Name;

	[FieldOffset(36)]
	public int StandardCount;

	[FieldOffset(40)]
	public StringReference Image;

	[FieldOffset(48)]
	public int ChallengeLeagueCount;

	[FieldOffset(52)]
	public TBool IsDisabled;

}
