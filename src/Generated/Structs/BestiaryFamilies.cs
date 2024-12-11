using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryFamilies
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	public TString Icon;

	[FieldOffset(24)]
	public TString IconSmall;

	[FieldOffset(32)]
	public TString Illustration;

	[FieldOffset(40)]
	public TString PageArt;

	[FieldOffset(48)]
	public TString FlavourText;

	[FieldOffset(56)]
	public TBool Unk007;

	[FieldOffset(57)]
	[ReferenceTable("Tags")]
	public TRef TagsKey;

	[FieldOffset(73)]
	public int Unk009;

	[FieldOffset(77)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(93)]
	[ReferenceTable("CurrencyItems")]
	public TRef CurrencyItemsKey;

}
