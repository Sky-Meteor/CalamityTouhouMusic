using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public class SulphurousSeaDay : BaseBiomeScene
{
    protected override bool ConfigValue => CTMConfig.Instance().SulphurousSeaDay;
    protected override string MusicSlot => CTMUtil.SulphurousSeaDay;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneSulphur && Main.dayTime;
}