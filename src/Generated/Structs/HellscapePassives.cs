using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HellscapePassives
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray Stats;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray StatsValues;

	[FieldOffset(48)]
	public int Points;

	[FieldOffset(52)]
	public int HASH16;

	[FieldOffset(56)]
	public TString Icon;

	[FieldOffset(64)]
	public TString IconMaxed;

	[FieldOffset(72)]
	[ReferenceTable("SoundEffects")]
	public TRef SoundEffect;

	[FieldOffset(88)]
	public int Unk009;

	[FieldOffset(92)]
	[ReferenceTable("Quest")]
	public TRef Quest;

}
