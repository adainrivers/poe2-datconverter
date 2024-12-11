using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GoldModPrices
{
	[FieldOffset(0)]
	[ReferenceTable("Mods")]
	public TRef Id;

	[FieldOffset(16)]
	public int Value;

	[FieldOffset(20)]
	public int Weight;

	[FieldOffset(24)]
	public int Unk003;

	[FieldOffset(28)]
	public int Unk004;

	[FieldOffset(32)]
	[ReferenceTable("Tags")]
	[ElementType(typeof(TRef))]
	public TArray Tags;

	[FieldOffset(48)]
	[ElementType(typeof(int))]
	public TArray SpawnWeight;

	[FieldOffset(64)]
	public TRef Unk007;

	[FieldOffset(80)]
	[ElementType(typeof(TRef))]
	public TArray Unk008;

}
