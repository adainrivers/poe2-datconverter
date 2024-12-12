namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct VoteType
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference Text;

	[FieldOffset(16)]
	public StringReference AcceptText;

	[FieldOffset(24)]
	public StringReference RejectText;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	public int Unk006;

	[FieldOffset(44)]
	public int Unk007;

}
