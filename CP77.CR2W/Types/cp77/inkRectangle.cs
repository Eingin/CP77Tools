using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkRectangle : CVariable
	{
		[Ordinal(0)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(1)]  [RED("width")] public CFloat Width { get; set; }
		[Ordinal(2)]  [RED("x")] public CFloat X { get; set; }
		[Ordinal(3)]  [RED("y")] public CFloat Y { get; set; }

		public inkRectangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
