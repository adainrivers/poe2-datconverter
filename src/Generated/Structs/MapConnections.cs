using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MapConnections
{
	[FieldOffset(0)]
	[ReferenceTable("MapPins")]
	public TRef MapPinsKey0;

	[FieldOffset(16)]
	[ReferenceTable("MapPins")]
	public TRef MapPinsKey1;

	[FieldOffset(32)]
	public TRef Unk002;

	[FieldOffset(48)]
	public TString RestrictedAreaText;

	[FieldOffset(56)]
	public TRef Unk004;

	[FieldOffset(72)]
	public TRef Unk005;

	[FieldOffset(88)]
	public TRef Unk006;

	[FieldOffset(104)]
	[ElementType(typeof(int))]
	public TArray Unk007;

}
