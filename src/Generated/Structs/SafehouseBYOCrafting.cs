using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct SafehouseBYOCrafting
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalJobs")]
	public TRef BetrayalJobsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalTargets")]
	public TRef BetrayalTargetsKey;

	[FieldOffset(32)]
	public int Rank;

	[FieldOffset(36)]
	public TString Description;

	[FieldOffset(44)]
	public TString ServerCommand;

	[FieldOffset(52)]
	[ElementType(typeof(TRef))]
	public TArray Unk005;

	[FieldOffset(68)]
	public TString Description2;

	[FieldOffset(76)]
	public TString ServerCommand2;

}
