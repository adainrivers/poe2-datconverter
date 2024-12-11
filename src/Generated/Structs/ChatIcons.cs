using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ChatIcons
{
	[FieldOffset(0)]
	public TString Icon;

	[FieldOffset(8)]
	public TString Image;

}
