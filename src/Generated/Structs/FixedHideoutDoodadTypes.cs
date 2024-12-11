using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FixedHideoutDoodadTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("HideoutDoodads")]
	[ElementType(typeof(TRef))]
	public TArray HideoutDoodadsKeys;

	[FieldOffset(24)]
	[ReferenceTable("HideoutDoodads")]
	public TRef BaseTypeHideoutDoodadsKey;

	[FieldOffset(40)]
	public int Unk003;

	[FieldOffset(44)]
	public int Unk004;

	[FieldOffset(48)]
	public bool Unk005;

	[FieldOffset(49)]
	public TRef Unk006;

	[FieldOffset(65)]
	public int Unk007;

	[FieldOffset(69)]
	public TRef Unk008;

}
