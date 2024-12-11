using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MinimapIcons
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinimapIconRadius;

	[FieldOffset(12)]
	public int LargemapIconRadius;

	[FieldOffset(16)]
	public bool Unk003;

	[FieldOffset(17)]
	public bool Unk004;

	[FieldOffset(18)]
	public bool Unk005;

	[FieldOffset(19)]
	public int MinimapIconPointerMaxDistance;

	[FieldOffset(23)]
	public int Unk007;

}
