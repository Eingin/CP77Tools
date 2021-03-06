using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCpoPickableItem : gameObject
	{
		[Ordinal(0)]  [RED("itemIDToEquip")] public TweakDBID ItemIDToEquip { get; set; }
		[Ordinal(1)]  [RED("quickSlotID")] public CInt32 QuickSlotID { get; set; }

		public gameCpoPickableItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
