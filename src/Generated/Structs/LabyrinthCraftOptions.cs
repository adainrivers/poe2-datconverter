using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct LabyrinthCraftOptions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("LabyrinthCraftOptionFamily")]
	[EnumName("LabyrinthCraftOptionFamily")]
	public TEnum CraftFamily;

	[FieldOffset(12)]
	public TString Text;

	[FieldOffset(20)]
	public TString Script;

	[FieldOffset(28)]
	public TString ScriptArgument;

	[FieldOffset(36)]
	public short HASH16;

	[FieldOffset(38)]
	public TBool Unk006;

	[FieldOffset(39)]
	[ReferenceTable("LabyrinthCraftOptionTiers")]
	public TRef Tier;

	[FieldOffset(55)]
	public TBool Unk008;

	[FieldOffset(56)]
	[ReferenceTable("AchievementItems")]
	[ElementType(typeof(TRef))]
	public TArray Achievement;

	[FieldOffset(72)]
	public TBool Unk010;

	[FieldOffset(73)]
	public TRef Unk011;

	[FieldOffset(89)]
	public int Unk012;

}
