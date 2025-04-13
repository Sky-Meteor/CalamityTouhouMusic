using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class Cryogen : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().Cryogen;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.Cryogen.Cryogen>();
    protected override string MusicSlot => CTMUtil.Cryogen;
}