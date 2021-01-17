using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Bump : animAnimFeature
	{
		[Ordinal(0)]  [RED("bumpType")] public CInt32 BumpType { get; set; }
		[Ordinal(1)]  [RED("direction")] public CFloat Direction { get; set; }
		[Ordinal(2)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(3)]  [RED("isBumping")] public CBool IsBumping { get; set; }
		[Ordinal(4)]  [RED("source")] public CFloat Source { get; set; }

		public animAnimFeature_Bump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
