using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisRecipes
{
	[FieldOffset(0)]
	[ReferenceTable("ArchnemesisMods")]
	public TRef Result;

	[FieldOffset(16)]
	[ReferenceTable("ArchnemesisMods")]
	[ElementType(typeof(TRef))]
	public TArray Recipe;

	[FieldOffset(32)]
	public int Unk002;

}
