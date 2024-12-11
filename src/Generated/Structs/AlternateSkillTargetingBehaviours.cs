using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AlternateSkillTargetingBehaviours
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int Unk001;

	[FieldOffset(12)]
	[ReferenceTable("ClientStrings")]
	public TRef ClientStrings;

	[FieldOffset(28)]
	public int Unk003;

	[FieldOffset(32)]
	public int Unk004;

	[FieldOffset(36)]
	public int Unk005;

	[FieldOffset(40)]
	[ElementType(typeof(int))]
	public TArray Unk006;

}
