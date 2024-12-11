using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SpectreOverrides
{
	[FieldOffset(0)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Monster;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TRef Spectre;

	[FieldOffset(32)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

}
