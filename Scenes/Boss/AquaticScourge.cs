using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class AquaticScourge : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AquaticScourge;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.AquaticScourge.AquaticScourgeHead>();
    protected override string MusicSlot => CTMUtil.AquaticScourge;
}