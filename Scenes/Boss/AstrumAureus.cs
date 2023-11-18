using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class AstrumAureus : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AstrumAureus;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.AstrumAureus.AstrumAureus>();
    protected override string MusicSlot => CTMUtil.AstrumAureus;
}