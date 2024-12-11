using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct TriggerSpawners
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(24)]
	public int Unk002;

	[FieldOffset(28)]
	[ElementType(typeof(int))]
	public TArray Unk003;

	[FieldOffset(44)]
	public bool Unk004;

}
