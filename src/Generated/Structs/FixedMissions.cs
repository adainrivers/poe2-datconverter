using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct FixedMissions
{
	[FieldOffset(0)]
	[ReferenceTable("QuestAchievements")]
	public TRef Unk000;

	[FieldOffset(16)]
	public TRef Unk001;

	[FieldOffset(32)]
	[ElementType(typeof(int))]
	public TArray Unk002;

	[FieldOffset(48)]
	public TRef Unk003;

	[FieldOffset(64)]
	public TRef Unk004;

	[FieldOffset(80)]
	public int Unk005;

	[FieldOffset(84)]
	public int Unk006;

	[FieldOffset(88)]
	public int Unk007;

}
