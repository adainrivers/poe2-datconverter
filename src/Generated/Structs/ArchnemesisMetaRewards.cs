using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisMetaRewards
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString RewardText;

	[FieldOffset(16)]
	public int RewardGroup;

	[FieldOffset(20)]
	public TString ScriptArgument;

	[FieldOffset(28)]
	public int MinLevel;

	[FieldOffset(32)]
	public int MaxLevel;

}
