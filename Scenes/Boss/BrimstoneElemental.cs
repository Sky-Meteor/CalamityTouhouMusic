using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class BrimstoneElemental : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().BrimstoneElemental;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.BrimstoneElemental.BrimstoneElemental>();
    protected override string MusicSlot => CTMUtil.BrimstoneElemental;
}