using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public class BrimstoneCrags : BaseBiomeScene
{
    protected override bool ConfigValue => CTMConfig.Instance().BrimstoneCrags;
    protected override string MusicSlot => CTMUtil.BrimstoneCrags;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneCalamity;
}