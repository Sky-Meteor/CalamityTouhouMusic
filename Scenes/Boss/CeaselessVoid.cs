using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class CeaselessVoid : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().CeaselessVoid;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.CeaselessVoid.CeaselessVoid>();
    protected override string MusicSlot => CTMUtil.CeaselessVoid;
}