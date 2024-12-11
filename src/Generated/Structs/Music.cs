using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Music
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString SoundFile;

	[FieldOffset(16)]
	public TString BankFile;

	[FieldOffset(24)]
	public int HASH16;

	[FieldOffset(28)]
	public TBool IsAvailableInHideout;

	[FieldOffset(29)]
	public TString Name;

	[FieldOffset(37)]
	public TString Unk006;

	[FieldOffset(45)]
	[ReferenceTable("MusicCategories")]
	[ElementType(typeof(TRef))]
	public TArray MusicCategories;

	[FieldOffset(61)]
	public TBool Unk008;

	[FieldOffset(62)]
	public int Unk009;

}
