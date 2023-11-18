using CalamityMod.NPCs.Ravager;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class Ravager : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().Ravager;
    protected override int BossID => ModContent.NPCType<RavagerBody>();
    protected override string MusicSlot => CTMUtil.Ravager;
}