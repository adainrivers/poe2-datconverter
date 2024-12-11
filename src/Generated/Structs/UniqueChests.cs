using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueChests
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("Words")]
	public TRef WordsKey;

	[FieldOffset(24)]
	[ReferenceTable("FlavourText")]
	public TRef FlavourTextKey;

	[FieldOffset(40)]
	public int MinLevel;

	[FieldOffset(44)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(60)]
	public int SpawnWeight;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk006;

	[FieldOffset(80)]
	public TString AOFile;

	[FieldOffset(88)]
	public TBool Unk008;

	[FieldOffset(89)]
	[ElementType(typeof(int))]
	public TArray Unk009;

	[FieldOffset(105)]
	[ReferenceTable("Chests")]
	public TRef AppearanceChestsKey;

	[FieldOffset(121)]
	[ReferenceTable("Chests")]
	public TRef ChestsKey;

	[FieldOffset(137)]
	[ElementType(typeof(TRef))]
	public TArray Unk012;

}
