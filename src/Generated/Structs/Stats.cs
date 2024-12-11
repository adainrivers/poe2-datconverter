using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct Stats
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public TBool Unk001;

	[FieldOffset(9)]
	public TBool IsLocal;

	[FieldOffset(10)]
	public TBool IsWeaponLocal;

	[FieldOffset(11)]
	[ReferenceTable("StatSemantics")]
	[EnumName("StatSemantics")]
	public TEnum Semantics;

	[FieldOffset(15)]
	public TString Text;

	[FieldOffset(23)]
	public TBool Unk006;

	[FieldOffset(24)]
	public TBool IsVirtual;

	[FieldOffset(25)]
	[ReferenceTable("Stats")]
	public TRef MainHandAlias_StatsKey;

	[FieldOffset(33)]
	[ReferenceTable("Stats")]
	public TRef OffHandAlias_StatsKey;

	[FieldOffset(41)]
	public TBool Unk010;

	[FieldOffset(42)]
	public int HASH32;

	[FieldOffset(46)]
	[ReferenceTable("ActiveSkills")]
	[ElementType(typeof(TString))]
	public TArray BelongsActiveSkillsKey;

	[FieldOffset(62)]
	[ReferenceTable("PassiveSkillStatCategories")]
	public TRef Category;

	[FieldOffset(78)]
	public TBool Unk014;

	[FieldOffset(79)]
	public TBool Unk015;

	[FieldOffset(80)]
	public TBool IsScalable;

	[FieldOffset(81)]
	[ReferenceTable("VirtualStatContextFlags")]
	[ElementType(typeof(TRef))]
	public TArray ContextFlags;

	[FieldOffset(97)]
	[ElementType(typeof(TRef))]
	public TArray Unk018;

}
