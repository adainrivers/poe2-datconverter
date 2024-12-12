using System;

namespace PoE2Converter.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueStashLayout
{
	[FieldOffset(0)]
	[ReferenceTable("Words")]
	public TableReference WordsKey;

	[FieldOffset(16)]
	[ReferenceTable("ItemVisualIdentity")]
	public TableReference ItemVisualIdentityKey;

	[FieldOffset(32)]
	[ReferenceTable("UniqueStashTypes")]
	public TableReference UniqueStashTypesKey;

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
	public TableReference RenamedVersion;

	//[FieldOffset(74)]
	//[ReferenceTable("UniqueStashLayout")]
	//public TableReference BaseVersion;

	[FieldOffset(80)]
	public TBool IsAlternateArt;

}
