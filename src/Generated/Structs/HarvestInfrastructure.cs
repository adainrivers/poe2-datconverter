using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HarvestInfrastructure
{
	[FieldOffset(0)]
	public TString Object;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStringsKey;

}
