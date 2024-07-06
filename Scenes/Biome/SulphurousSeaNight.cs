using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public class SulphurousSeaNight : BaseBiomeScene
{
    protected override bool ConfigValue => CTMConfig.Instance().SulphurousSeaNight;
    protected override string MusicSlot => CTMUtil.SulphurousSeaNight;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneSulphur && !Main.dayTime;
}