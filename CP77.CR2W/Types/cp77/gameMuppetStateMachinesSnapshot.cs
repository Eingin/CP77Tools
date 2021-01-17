using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachinesSnapshot : CVariable
	{
		[Ordinal(0)]  [RED("stateMachines")] public CArray<gameMuppetStateMachineSnapshot> StateMachines { get; set; }

		public gameMuppetStateMachinesSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
