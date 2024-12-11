using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PlayerConditions
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BuffDefinitions")]
	[ElementType(typeof(TRef))]
	public TArray BuffDefinitionsKeys;

	[FieldOffset(24)]
	public TBool Unk002;

	[FieldOffset(25)]
	public int BuffStacks;

	[FieldOffset(29)]
	[ReferenceTable("Characters")]
	public TRef CharactersKey;

	[FieldOffset(45)]
	[ReferenceTable("Stats")]
	[ElementType(typeof(TRef))]
	public TArray StatsKeys;

	[FieldOffset(61)]
	public TBool Unk006;

	[FieldOffset(62)]
	public int StatValue;

	[FieldOffset(66)]
	[ElementType(typeof(TRef))]
	public TArray Unk008;

	[FieldOffset(82)]
	public TBool Unk009;

}
