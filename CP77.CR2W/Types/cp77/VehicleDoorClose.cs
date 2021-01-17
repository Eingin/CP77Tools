using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorClose : ActionBool
	{
		[Ordinal(0)]  [RED("isInteractionSource")] public CBool IsInteractionSource { get; set; }
		[Ordinal(1)]  [RED("slotID")] public CName SlotID { get; set; }

		public VehicleDoorClose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
