using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("attributes")] public CyberwareAttributes_ContainersStruct Attributes { get; set; }
		[Ordinal(1)]  [RED("devPoints")] public CInt32 DevPoints { get; set; }
		[Ordinal(2)]  [RED("levelUpPoints")] public inkTextWidgetReference LevelUpPoints { get; set; }
		[Ordinal(3)]  [RED("playerPuppet")] public wCHandle<PlayerPuppet> PlayerPuppet { get; set; }
		[Ordinal(4)]  [RED("resistances")] public CyberwareAttributes_ResistancesStruct Resistances { get; set; }
		[Ordinal(5)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }

		public CyberwareAttributesSkills(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
