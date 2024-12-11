using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Environments
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Base_ENVFile;

	[FieldOffset(16)]
	[ElementType(typeof(TString))]
	public TArray Corrupted_ENVFiles;

	[FieldOffset(32)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(48)]
	[ElementType(typeof(TRef))]
	public TArray Unk004;

	[FieldOffset(64)]
	[ElementType(typeof(int))]
	public TArray Unk005;

	[FieldOffset(80)]
	[ReferenceTable("EnvironmentTransitions")]
	public TRef EnvironmentTransitionsKey;

	[FieldOffset(96)]
	[ReferenceTable("PreloadGroups")]
	public TRef PreloadGroup;

}
