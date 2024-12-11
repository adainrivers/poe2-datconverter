using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AchievementItems
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	public int Unk002;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	public int CompletionsRequired;

	[FieldOffset(28)]
	[ReferenceTable("Achievements")]
	public TRef AchievementsKey;

	[FieldOffset(44)]
	public bool Unk006;

	[FieldOffset(45)]
	public bool Unk007;

	[FieldOffset(46)]
	public bool Unk008;

	[FieldOffset(47)]
	public bool Unk009;

}
