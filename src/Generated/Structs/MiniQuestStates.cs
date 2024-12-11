using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MiniQuestStates
{
	[FieldOffset(0)]
	public int Unk000;

	[FieldOffset(4)]
	[ElementType(typeof(int))]
	public TArray Unk001;

	[FieldOffset(20)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(36)]
	public int Unk003;

}
