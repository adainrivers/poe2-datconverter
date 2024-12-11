using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct CloneShot
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVarietiesKey;

	[FieldOffset(20)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated1;

	[FieldOffset(36)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated2;

	[FieldOffset(52)]
	[ReferenceTable("MiscAnimated")]
	public TRef MiscAnimated3;

}
