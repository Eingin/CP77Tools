using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCStatePrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listenerInt")] public CUInt32 ListenerInt { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("prevValue")] public CInt32 PrevValue { get; set; }

		public NPCStatePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
