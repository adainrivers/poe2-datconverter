using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct GamepadButtonCombination
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	[ReferenceTable("GamepadButton")]
	public TRef Button1;

	[FieldOffset(24)]
	[ReferenceTable("GamepadButton")]
	public TRef Button2;

	[FieldOffset(40)]
	public int Unk003;

}
