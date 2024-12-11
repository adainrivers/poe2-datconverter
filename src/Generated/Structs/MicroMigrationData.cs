using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MicroMigrationData
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public TRef Unk002;

	[FieldOffset(36)]
	public TRef Unk003;

}
