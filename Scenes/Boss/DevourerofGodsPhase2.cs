using CalamityMod.NPCs;
using CalamityMod.NPCs.DevourerofGods;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class DevourerofGodsPhase2 : BaseBossScene
{
	public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
	protected override bool ConfigValue => CTMConfig.Instance().DevourerofGodsPhase2;
    protected override int BossID => ModContent.NPCType<DevourerofGodsHead>();
    protected override string MusicSlot => CTMUtil.DevourerofGodsPhase2;
    public override int[] AdditionalNPCs => new int[]
    {
	    ModContent.NPCType<DevourerofGodsBody>(),
	    ModContent.NPCType<DevourerofGodsTail>()
    };

    public override bool AdditionalCheck() => CalamityGlobalNPC.DoGP2 != -1;
}