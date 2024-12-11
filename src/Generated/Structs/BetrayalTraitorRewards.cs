using System;
using System.Runtime.InteropServices;
namespace Extractor.Generated.Structs;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct BetrayalTraitorRewards
{
	[FieldOffset(0)]
	[ReferenceTable("BetrayalJobs")]
	public TRef BetrayalJobsKey;

	[FieldOffset(16)]
	[ReferenceTable("BetrayalTargets")]
	public TRef BetrayalTargetsKey;

	[FieldOffset(32)]
	[ReferenceTable("BetrayalRanks")]
	public TRef BetrayalRanksKey;

	[FieldOffset(48)]
	public TString Description;

	[FieldOffset(56)]
	public TString Description2;

}
