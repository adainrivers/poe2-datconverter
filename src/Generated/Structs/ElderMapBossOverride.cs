using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ElderMapBossOverride
{
	[FieldOffset(0)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray MonsterVarietiesKeys;

	[FieldOffset(32)]
	public TString TerrainMetadata;

}
