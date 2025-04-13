using CalamityMod.NPCs.DesertScourge;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class DesertScourge : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().DesertScourge;
    protected override int BossID => ModContent.NPCType<DesertScourgeHead>();
    protected override string MusicSlot => CTMUtil.DesertScourge;
    public override int[] AdditionalNPCs => new int[]
    {
	    ModContent.NPCType<DesertScourgeBody>(),
	    ModContent.NPCType<DesertScourgeTail>()
    };
}