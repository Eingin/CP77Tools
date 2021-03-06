using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemsNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(0)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(1)]  [RED("combatModeListener")] public CUInt32 CombatModeListener { get; set; }
		[Ordinal(2)]  [RED("combatModePSM")] public CEnum<gamePSMCombat> CombatModePSM { get; set; }
		[Ordinal(3)]  [RED("comparisonResolver")] public CHandle<ItemPreferredComparisonResolver> ComparisonResolver { get; set; }
		[Ordinal(4)]  [RED("currencyInventoryListener")] public wCHandle<gameInventoryScriptListener> CurrencyInventoryListener { get; set; }
		[Ordinal(5)]  [RED("currencyNotification")] public CName CurrencyNotification { get; set; }
		[Ordinal(6)]  [RED("inventoryListener")] public wCHandle<gameInventoryScriptListener> InventoryListener { get; set; }
		[Ordinal(7)]  [RED("itemNotification")] public CName ItemNotification { get; set; }
		[Ordinal(8)]  [RED("playerDevelopmentSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem { get; set; }
		[Ordinal(9)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(10)]  [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(11)]  [RED("showDuration")] public CFloat ShowDuration { get; set; }
		[Ordinal(12)]  [RED("transactionSystem")] public wCHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(13)]  [RED("xpNotification")] public CName XpNotification { get; set; }

		public ItemsNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
