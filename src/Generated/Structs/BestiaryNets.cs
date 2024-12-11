using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BestiaryNets
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItemTypesKey;

	[FieldOffset(16)]
	public int Unk001;

	[FieldOffset(20)]
	public int CaptureMinLevel;

	[FieldOffset(24)]
	public int CaptureMaxLevel;

	[FieldOffset(28)]
	public int DropMinLevel;

	[FieldOffset(32)]
	public int DropMaxLevel;

	[FieldOffset(36)]
	public int Unk006;

	[FieldOffset(40)]
	public bool IsEnabled;

}
