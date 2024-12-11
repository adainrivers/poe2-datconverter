using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MissionTimerTypes
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TString Image;

	[FieldOffset(16)]
	public TString BackgroundImage;

	[FieldOffset(24)]
	[ElementType(typeof(TRef))]
	public TArray Unk003;

	[FieldOffset(40)]
	[ElementType(typeof(float))]
	public TArray Unk004;

	[FieldOffset(56)]
	public TRef Unk005;

	[FieldOffset(72)]
	public TRef Unk006;

}
