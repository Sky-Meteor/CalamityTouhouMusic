using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public class SunkenSea : BaseBiomeScene
{
    protected override bool ConfigValue => CTMConfig.Instance().SunkenSea;
    protected override string MusicSlot => CTMUtil.SunkenSea;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneSunkenSea;
}