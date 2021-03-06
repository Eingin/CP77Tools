using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponSettingsGroup : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("npcSettings")] public CName NpcSettings { get; set; }
		[Ordinal(1)]  [RED("npcSilenced")] public CName NpcSilenced { get; set; }
		[Ordinal(2)]  [RED("playerSettings")] public CName PlayerSettings { get; set; }
		[Ordinal(3)]  [RED("playerSilenced")] public CName PlayerSilenced { get; set; }

		public audioWeaponSettingsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
