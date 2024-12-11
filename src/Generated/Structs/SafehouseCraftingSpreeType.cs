using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SafehouseCraftingSpreeType
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("SafehouseCraftingSpreeCurrencies")]
	[ElementType(typeof(TRef))]
	public TArray Currencies;

	[FieldOffset(24)]
	[ElementType(typeof(int))]
	public TArray CurrencyCount;

	[FieldOffset(40)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(56)]
	public bool Disabled;

	[FieldOffset(57)]
	public TString ItemClassText;

	[FieldOffset(65)]
	public int Unk006;

}
