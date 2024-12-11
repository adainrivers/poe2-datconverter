using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct HeistNPCAuras
{
	[FieldOffset(0)]
	[ReferenceTable("Stats")]
	public TRef Stat;

	[FieldOffset(16)]
	[ReferenceTable("GrantedEffects")]
	public TRef GrantedEffect;

}
