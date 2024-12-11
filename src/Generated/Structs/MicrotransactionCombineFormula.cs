using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicrotransactionCombineFormula
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Result_BaseItemTypesKey;

	[FieldOffset(24)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Ingredients_BaseItemTypesKeys;

	[FieldOffset(40)]
	public TString BK2File;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray Unk004;

	[FieldOffset(64)]
	public int Unk005;

	[FieldOffset(68)]
	public bool Unk006;

}
