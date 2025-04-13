using CalamityMod.Events;
using CalamityMod.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class AquaticScourge : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AquaticScourge;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.AquaticScourge.AquaticScourgeHead>();
    protected override string MusicSlot => CTMUtil.AquaticScourge;

    public override bool AdditionalCheck()
	{
		if (CalamityGlobalNPC.aquaticScourge == -1)
			return false;
		return Main.npc[CalamityGlobalNPC.aquaticScourge].justHit ||
		       Main.npc[CalamityGlobalNPC.aquaticScourge].life <= Main.npc[CalamityGlobalNPC.aquaticScourge].lifeMax * 0.999 ||
		       BossRushEvent.BossRushActive || Main.getGoodWorld;
	}
}