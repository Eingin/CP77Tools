using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSVisualTagProcessing : CVariable
	{
		[Ordinal(0)]  [RED("areaType")] public CEnum<gamedataEquipmentArea> AreaType { get; set; }
		[Ordinal(1)]  [RED("showItem")] public CBool ShowItem { get; set; }

		public gameSVisualTagProcessing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
