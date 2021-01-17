using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimetableCallbackData : IScriptable
	{
		[Ordinal(0)]  [RED("callbackID")] public CUInt32 CallbackID { get; set; }
		[Ordinal(1)]  [RED("recipients")] public CArray<RecipientData> Recipients { get; set; }
		[Ordinal(2)]  [RED("time")] public SSimpleGameTime Time { get; set; }

		public TimetableCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
