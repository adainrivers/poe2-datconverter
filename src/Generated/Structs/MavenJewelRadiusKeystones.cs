using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct MavenJewelRadiusKeystones
{
	[FieldOffset(0)]
	[ReferenceTable("PassiveSkills")]
	public TRef Keystone;

}
