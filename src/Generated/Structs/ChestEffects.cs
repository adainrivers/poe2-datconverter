using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChestEffects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Normal_EPKFile;

	[FieldOffset(16)]
	public TString Normal_Closed_AOFile;

	[FieldOffset(24)]
	public TString Normal_Open_AOFile;

	[FieldOffset(32)]
	public TString Magic_EPKFile;

	[FieldOffset(40)]
	public TString Unique_EPKFile;

	[FieldOffset(48)]
	public TString Rare_EPKFile;

	[FieldOffset(56)]
	public TString Magic_Closed_AOFile;

	[FieldOffset(64)]
	public TString Unique_Closed_AOFile;

	[FieldOffset(72)]
	public TString Rare_Closed_AOFile;

	[FieldOffset(80)]
	public TString Magic_Open_AOFile;

	[FieldOffset(88)]
	public TString Unique_Open_AOFile;

	[FieldOffset(96)]
	public TString Rare_Open_AOFile;

}
