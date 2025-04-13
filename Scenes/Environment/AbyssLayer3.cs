using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

public class AbyssLayer3 : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AbyssLayer3;
    protected override string MusicSlot => CTMUtil.AbyssLayers;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAbyssLayer2;
}