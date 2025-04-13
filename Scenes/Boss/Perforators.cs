using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class Perforators : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().Perforators;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.Perforator.PerforatorHive>();
    protected override string MusicSlot => CTMUtil.Perforators;
}