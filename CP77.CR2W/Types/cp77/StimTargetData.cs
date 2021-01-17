using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimTargetData : CVariable
	{
		[Ordinal(0)]  [RED("entryID")] public CName EntryID { get; set; }
		[Ordinal(1)]  [RED("spawnerRef")] public NodeRef SpawnerRef { get; set; }

		public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}