using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct PackFrequencyNames
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public float Frequency;

	[FieldOffset(12)]
	[ReferenceTable("ClientStrings")]
	public TRef Text;

}
