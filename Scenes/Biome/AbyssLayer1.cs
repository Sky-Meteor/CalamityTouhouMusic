using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public class AbyssLayer1 : BaseBiomeScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AbyssLayer1;
    protected override string MusicSlot => CTMUtil.AbyssLayer1;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAbyssLayer1;
}