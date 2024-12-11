using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemCosts
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Cost1Currencies;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray Cost1Values;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Cost2Currencies;

	[FieldOffset(56)]
	[ElementType(typeof(int))]
	public TArray Cost2Values;

	[FieldOffset(72)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Cost3Currencies;

	[FieldOffset(88)]
	[ElementType(typeof(int))]
	public TArray Cost3Values;

	[FieldOffset(104)]
	[ReferenceTable("BaseItemTypes")]
	[ElementType(typeof(TRef))]
	public TArray Cost4Currencies;

	[FieldOffset(120)]
	[ElementType(typeof(int))]
	public TArray Cost4Values;

	[FieldOffset(136)]
	[ElementType(typeof(int))]
	public TArray Unk009;

}
