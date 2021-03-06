using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveMotionPlannerComponent : moveIMotionPlannerComponent
	{
		[Ordinal(0)]  [RED("snapToGround")] public CBool SnapToGround { get; set; }

		public moveMotionPlannerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
