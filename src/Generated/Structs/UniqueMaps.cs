using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct UniqueMaps
{
	[FieldOffset(0)]
	[ReferenceTable("ItemVisualIdentity")]
	public TRef ItemVisualIdentityKey;

	[FieldOffset(16)]
	[ReferenceTable("WorldAreas")]
	public TRef WorldAreasKey;

	[FieldOffset(32)]
	[ReferenceTable("Words")]
	public TRef WordsKey;

	[FieldOffset(48)]
	[ReferenceTable("FlavourText")]
	public TRef FlavourTextKey;

	[FieldOffset(64)]
	public bool HasGuildCharacter;

	[FieldOffset(65)]
	public TString GuildCharacter;

	[FieldOffset(73)]
	public TString Name;

	[FieldOffset(81)]
	public bool IsDropDisabled;

}
