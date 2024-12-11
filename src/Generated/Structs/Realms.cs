using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Realms
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Name;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray Server;

	[FieldOffset(32)]
	public TBool IsEnabled;

	[FieldOffset(33)]
	[ElementType(typeof(TString))]
	public TArray Server2;

	[FieldOffset(49)]
	public TString ShortName;

	[FieldOffset(57)]
	[ReferenceTable("Realms")]
	[ElementType(typeof(TRef))]
	public TArray Unk006;

	[FieldOffset(73)]
	[ReferenceTable("Realms")]
	public TRef Unk007;

	[FieldOffset(81)]
	public int Unk008;

	[FieldOffset(85)]
	public TBool IsGammaRealm;

	[FieldOffset(86)]
	[ElementType(typeof(TString))]
	public TArray SpeedtestUrl;

}
