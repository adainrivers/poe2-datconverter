using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AtlasPrimordialAltarChoices
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(16)]
	[ReferenceTable("AtlasPrimordialAltarChoiceTypes")]
	public TRef Type;

	[FieldOffset(32)]
	public bool Unk002;

}
