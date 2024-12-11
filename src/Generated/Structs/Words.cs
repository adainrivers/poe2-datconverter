using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Words
{
	[FieldOffset(0)]
	[ReferenceTable("Wordlists")]
	[EnumName("Wordlists")]
	public TEnum Wordlist;

	[FieldOffset(4)]
	public TString Text;

	[FieldOffset(12)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray SpawnWeight_Tags;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight_Values;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public TString Text2;

	[FieldOffset(56)]
	public TString Inflection;

}
