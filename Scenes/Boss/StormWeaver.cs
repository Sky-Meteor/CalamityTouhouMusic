using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class StormWeaver : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().StormWeaver;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.StormWeaver.StormWeaverHead>();
    protected override string MusicSlot => CTMUtil.StormWeaver;
}