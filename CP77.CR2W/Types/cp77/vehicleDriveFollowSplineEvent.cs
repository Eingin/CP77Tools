using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowSplineEvent : redEvent
	{
		[Ordinal(0)]  [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(1)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(2)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }

		public vehicleDriveFollowSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
