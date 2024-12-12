namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LeagueFlag
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Image;

	[FieldOffset(16)]
	public TBool IsHC;

	[FieldOffset(17)]
	public TBool IsSSF;

	[FieldOffset(18)]
	public StringReference Banner;

	[FieldOffset(26)]
	public TBool IsRuthless;

}
