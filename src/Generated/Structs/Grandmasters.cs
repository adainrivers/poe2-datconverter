using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Grandmasters
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString GMFile;

	[FieldOffset(16)]
	public TString AISFile;

	[FieldOffset(24)]
	[ReferenceTable("Mods")]
	[ElementType(typeof(TRef))]
	public TArray ModsKeys;

	[FieldOffset(40)]
	public int CharacterLevel;

	[FieldOffset(44)]
	public TBool Unk005;

}
