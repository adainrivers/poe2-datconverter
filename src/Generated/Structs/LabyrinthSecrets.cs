using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthSecrets
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Id2;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(32)]
	public int Unk003;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	[ReferenceTable("LabyrinthSecretEffects")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSecretEffectsKeys0;

	[FieldOffset(56)]
	[ReferenceTable("LabyrinthSecretEffects")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSecretEffectsKeys1;

	[FieldOffset(72)]
	[ReferenceTable("LabyrinthSecretEffects")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSecretEffectsKeys2;

	[FieldOffset(88)]
	public int Unk008;

	[FieldOffset(92)]
	[ReferenceTable("LabyrinthSecretEffects")]
	[ElementType(typeof(TRef))]
	public TArray LabyrinthSecretEffectsKeys3;

	[FieldOffset(108)]
	public TBool Unk010;

	[FieldOffset(109)]
	public TBool Unk011;

	[FieldOffset(110)]
	public int Unk012;

	[FieldOffset(114)]
	public TBool Unk013;

	[FieldOffset(115)]
	public TBool Unk014;

	[FieldOffset(116)]
	public TBool Unk015;

	[FieldOffset(117)]
	public TString Name;

	[FieldOffset(125)]
	[ReferenceTable("AchievementItems")]
	public TRef AchievementItemsKey;

	[FieldOffset(141)]
	public int LabyrinthTierMinimum;

	[FieldOffset(145)]
	public int LabyrinthTierMaximum;

	[FieldOffset(149)]
	public TBool Unk020;

}
