using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueStashLayout
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TRef WordsKey;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentityKey;

	[FieldOffset(32)]
	[ReferenceTable("UniqueStashTypes")]
	public TRef UniqueStashTypesKey;

	[FieldOffset(48)]
	public int Unk003;

	[FieldOffset(52)]
	public int Unk004;

	[FieldOffset(56)]
	public int OverrideWidth;

	[FieldOffset(60)]
	public int OverrideHeight;

	[FieldOffset(64)]
	public TBool ShowIfEmptyChallengeLeague;

	[FieldOffset(65)]
	public TBool ShowIfEmptyStandard;

	[FieldOffset(66)]
	[ReferenceTable("UniqueStashLayout")]
	public TRef RenamedVersion;

	[FieldOffset(74)]
	[ReferenceTable("UniqueStashLayout")]
	public TRef BaseVersion;

	[FieldOffset(82)]
	public TBool IsAlternateArt;

}
