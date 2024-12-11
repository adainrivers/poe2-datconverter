using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ClientLakeDifficulty
{
	[FieldOffset(0)]
	public int Id;

	[FieldOffset(4)]
	public float Scaling;

	[FieldOffset(8)]
	public int Unk002;

	[FieldOffset(12)]
	public int Unk003;

}
