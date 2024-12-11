using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightedSporeAuras
{
	[FieldOffset(0)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey;

	[FieldOffset(16)]
	[ElementType(typeof(int))]
	public TArray BuffStatValues;

	[FieldOffset(32)]
	public int Unk002;

	[FieldOffset(36)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(52)]
	public int Unk004;

}
