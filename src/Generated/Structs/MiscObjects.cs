using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiscObjects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString EffectVirtualPath;

	[FieldOffset(16)]
	[ReferenceTable("PreloadGroups")]
	[ElementType(typeof(TRef))]
	public TArray PreloadGroupsKeys;

	[FieldOffset(32)]
	public int Unk003;

	[FieldOffset(36)]
	public int Unk004;

	[FieldOffset(40)]
	public int Unk005;

}
