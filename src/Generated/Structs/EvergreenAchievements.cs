using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EvergreenAchievements
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	public int Unk001;

	[FieldOffset(8)]
	[ElementType(typeof(TRef))]
	public TArray Unk002;

}
