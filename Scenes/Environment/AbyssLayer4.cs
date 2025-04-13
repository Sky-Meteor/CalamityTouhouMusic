using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

public class AbyssLayer4 : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AbyssLayer4;
    protected override string MusicSlot => CTMUtil.AbyssLayers;
    
    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAbyssLayer2;
}