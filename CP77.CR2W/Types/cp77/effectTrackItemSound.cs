using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemSound : effectTrackItem
	{
		[Ordinal(0)]  [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)]  [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(3)]  [RED("positionName")] public CName PositionName { get; set; }
		[Ordinal(4)]  [RED("rtpcName")] public CName RtpcName { get; set; }
		[Ordinal(5)]  [RED("rtpcValue")] public CHandle<IEvaluatorFloat> RtpcValue { get; set; }
		[Ordinal(6)]  [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }

		public effectTrackItemSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
