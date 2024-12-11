using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ArchnemesisMods
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Mod;

	[FieldOffset(16)]
	public TString Name;

	[FieldOffset(24)]
	[ReferenceTable("ArchnemesisModVisuals")]
	public TRef Visual;

	[FieldOffset(40)]
	[ElementType(typeof(TString))]
	public TArray TextStyles;

	[FieldOffset(56)]
	public TBool Unk004;

	[FieldOffset(57)]
	public TBool Unk005;

}
