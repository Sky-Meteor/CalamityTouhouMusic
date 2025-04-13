using CalamityMod.NPCs.StormWeaver;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class StormWeaver : BaseBossScene
{
    protected override bool ConfigValue => CTMConfig.Instance().StormWeaver;
    protected override int BossID => ModContent.NPCType<StormWeaverHead>();
    protected override string MusicSlot => CTMUtil.StormWeaver;
    public override int[] AdditionalNPCs => new int[]
    {
	    ModContent.NPCType<StormWeaverBody>(),
	    ModContent.NPCType<StormWeaverTail>()
    };
}