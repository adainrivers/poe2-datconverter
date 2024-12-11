using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EclipseMods
{
	[FieldOffset(0)]
	public TString Key;

	[FieldOffset(8)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray SpawnWeight_TagsKeys;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight_Values;

	[FieldOffset(40)]
	[ReferenceTable("Mods")]
	public TRef ModsKey;

	[FieldOffset(56)]
	public int MinLevel;

	[FieldOffset(60)]
	public int MaxLevel;

	[FieldOffset(64)]
	public bool IsPrefix;

}
