using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class PlaguebringerGoliath : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().PlaguebringerGoliath;
    protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.PlaguebringerGoliath.PlaguebringerGoliath>();
    protected override string MusicSlot => CTMUtil.PlaguebringerGoliath;
}