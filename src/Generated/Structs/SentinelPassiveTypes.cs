using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SentinelPassiveTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString DefaultIcon;

	[FieldOffset(16)]
	public TString ActiveIcon;

	[FieldOffset(24)]
	[ReferenceTable("DroneTypes")]
	public TRef DroneType;

	[FieldOffset(40)]
	public int Unk004;

}
