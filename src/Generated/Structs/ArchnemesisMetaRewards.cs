namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisMetaRewards
{
	[FieldOffset(0)]
	public StringReference Id;

	[FieldOffset(8)]
	public StringReference RewardText;

	[FieldOffset(16)]
	public int RewardGroup;

	[FieldOffset(20)]
	public StringReference ScriptArgument;

	[FieldOffset(28)]
	public int MinLevel;

	[FieldOffset(32)]
	public int MaxLevel;

}
