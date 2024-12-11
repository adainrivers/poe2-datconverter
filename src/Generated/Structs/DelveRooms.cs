using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct DelveRooms
{
	[FieldOffset(0)]
	[ReferenceTable("DelveBiomes")]
	public TRef DelveBiomesKey;

	[FieldOffset(16)]
	[ReferenceTable("DelveFeatures")]
	public TRef DelveFeaturesKey;

	[FieldOffset(32)]
	public TString ARMFile;

}
