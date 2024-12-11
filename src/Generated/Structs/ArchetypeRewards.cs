using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchetypeRewards
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TRef Unk001;

	[FieldOffset(24)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

	[FieldOffset(40)]
	[ReferenceTable("BaseItemTypes")]
	public TRef Gem;

	[FieldOffset(56)]
	public TString BK2File;

}
