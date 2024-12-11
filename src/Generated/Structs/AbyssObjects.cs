using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct AbyssObjects
{
	[FieldOffset(0)]
	public TString Id;

	[FieldOffset(8)]
	public int MinLevel;

	[FieldOffset(12)]
	public int MaxLevel;

	[FieldOffset(16)]
	public int SpawnWeight;

	[FieldOffset(20)]
	public int Unk004;

	[FieldOffset(24)]
	public TString MetadataFile;

	[FieldOffset(32)]
	public int Unk006;

	[FieldOffset(36)]
	[ReferenceTable("MonsterVarieties")]
	[ElementType(typeof(TRef))]
	public TArray DaemonSpawners;

	[FieldOffset(52)]
	public int Unk008;

	[FieldOffset(56)]
	public int Unk009;

	[FieldOffset(60)]
	[ReferenceTable("WorldAreas")]
	public TRef AbyssalDepths;

	[FieldOffset(76)]
	public int Unk011;

	[FieldOffset(80)]
	public int Unk012;

	[FieldOffset(84)]
	public int Unk013;

	[FieldOffset(88)]
	public int Unk014;

	[FieldOffset(92)]
	public int Unk015;

	[FieldOffset(96)]
	public int Unk016;

	[FieldOffset(100)]
	public int Unk017;

	[FieldOffset(104)]
	public int Unk018;

	[FieldOffset(108)]
	public int Unk019;

	[FieldOffset(112)]
	public TBool Unk020;

}
