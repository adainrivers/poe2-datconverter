using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BlightTowerAuras
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("BuffDefinitions")]
	public TRef BuffDefinitionsKey;

	[FieldOffset(20)]
	public int Unk002;

	[FieldOffset(24)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimatedKey;

}
