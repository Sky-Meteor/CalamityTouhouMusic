using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

// 同硫磺海
public class AbyssLayer1 : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AbyssLayer1;
    protected override string MusicSlot => Main.dayTime ? CTMUtil.SulphurousSeaDay : CTMUtil.SulphurousSeaNight; // CTMUtil.AbyssLayer1;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAbyssLayer1;
}