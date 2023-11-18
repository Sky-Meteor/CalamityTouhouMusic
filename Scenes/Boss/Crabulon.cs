using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class Crabulon : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().Crabulon;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.Crabulon.Crabulon>();
    protected override string MusicSlot => CTMUtil.Crabulon;
}