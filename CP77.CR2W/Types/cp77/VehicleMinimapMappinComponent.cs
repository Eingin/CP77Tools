using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleMinimapMappinComponent : IScriptable
	{
		[Ordinal(0)]  [RED("minimapPOIMappinController")] public wCHandle<MinimapPOIMappinController> MinimapPOIMappinController { get; set; }
		[Ordinal(1)]  [RED("vehicleEntityID")] public entEntityID VehicleEntityID { get; set; }
		[Ordinal(2)]  [RED("vehicleIsLatestSummoned")] public CBool VehicleIsLatestSummoned { get; set; }
		[Ordinal(3)]  [RED("vehicleSummonDataBB")] public CHandle<gameIBlackboard> VehicleSummonDataBB { get; set; }
		[Ordinal(4)]  [RED("vehicleSummonDataDef")] public CHandle<VehicleSummonDataDef> VehicleSummonDataDef { get; set; }
		[Ordinal(5)]  [RED("vehicleSummonStateCallback")] public CUInt32 VehicleSummonStateCallback { get; set; }

		public VehicleMinimapMappinComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
