namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Notifications
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool Unk002;

	[FieldOffset(10)]
	public StringReference Message;

	[FieldOffset(18)]
	public StringReference Unk004;

	[FieldOffset(26)]
	public int Unk005;

	[FieldOffset(30)]
	public TBool Unk006;

	[FieldOffset(31)]
	public TBool Unk007;

}
