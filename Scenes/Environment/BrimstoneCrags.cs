using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

public class BrimstoneCrags : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().BrimstoneCrags;
    protected override string MusicSlot => CTMUtil.BrimstoneCrags;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneCalamity;
}