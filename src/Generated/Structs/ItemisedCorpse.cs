using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct ItemisedCorpse
{
	[FieldOffset(0)]
	[ReferenceTable("BaseItemTypes")]
	public TRef BaseItem;

	[FieldOffset(16)]
	[ReferenceTable("MonsterVarieties")]
	public TRef MonsterVariety;

	[FieldOffset(32)]
	public TString MonsterAbilities;

	[FieldOffset(40)]
	[ReferenceTable("CorpseTypeTags")]
	public TRef MonsterCategory;

}
