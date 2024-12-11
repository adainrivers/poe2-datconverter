using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UltimatumEncounters
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Description;

	[FieldOffset(16)]
	[ReferenceTable("UltimatumModifierTypes")]
	[ElementType(typeof(TRef))]
	public TArray ModTypes;

	[FieldOffset(32)]
	public TString BossARMFile;

	[FieldOffset(40)]
	[ReferenceTable("UltimatumEncounterTypes")]
	public TRef Type;

	[FieldOffset(56)]
	public TString Icon;

	[FieldOffset(64)]
	public int HASH16;

	[FieldOffset(68)]
	public bool Unk007;

	[FieldOffset(69)]
	public int Unk008;

	[FieldOffset(73)]
	public bool Unk009;

}
