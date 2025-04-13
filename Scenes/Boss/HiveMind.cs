using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class HiveMind : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().HiveMind;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.HiveMind.HiveMind>();
    protected override string MusicSlot => CTMUtil.HiveMind;
}