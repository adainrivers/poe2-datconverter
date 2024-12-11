using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalDialogue
{
	[FieldOffset(0)]
	public TRef Unk000;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(40)]
	[ReferenceTable("BetrayalTargets")]
	public TRef BetrayalTargetsKey;

	[FieldOffset(56)]
	public int Unk005;

	[FieldOffset(60)]
	public TRef Unk006;

	[FieldOffset(76)]
	[ElementType(typeof(TRef))]
	public TArray Unk007;

	[FieldOffset(92)]
	[ReferenceTable("BetrayalUpgrades")]
	public TRef BetrayalUpgradesKey;

	[FieldOffset(108)]
	public bool Unk009;

	[FieldOffset(109)]
	[ElementType(typeof(int))]
	public TArray Unk010;

	[FieldOffset(125)]
	[ElementType(typeof(TRef))]
	public TArray Unk011;

	[FieldOffset(141)]
	public bool Unk012;

	[FieldOffset(142)]
	[ElementType(typeof(int))]
	public TArray Unk013;

	[FieldOffset(158)]
	[ReferenceTable("NPCTextAudio")]
	public TRef NPCTextAudioKey;

	[FieldOffset(174)]
	[ElementType(typeof(int))]
	public TArray Unk015;

}
