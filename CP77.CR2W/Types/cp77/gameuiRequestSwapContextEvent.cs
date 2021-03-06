using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRequestSwapContextEvent : redEvent
	{
		[Ordinal(0)]  [RED("newContext")] public CEnum<UIGameContext> NewContext { get; set; }
		[Ordinal(1)]  [RED("oldContext")] public CEnum<UIGameContext> OldContext { get; set; }

		public gameuiRequestSwapContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
