using CalamityMod;
using Terraria;
using Terraria.ModLoader;
using CalamityTouhouMusic.Scenes.Environment;
using Terraria.GameContent.Events;

namespace CalamityTouhouMusic.Scenes.Biome;

public class AstralInfection : BaseEnvironmentScene
{
    public override SceneEffectPriority Priority
    {
        get
        {
            if (Main.LocalPlayer.ZoneDesert && Sandstorm.Happening && !(Main.LocalPlayer.ZoneSnow || Main.slimeRain || Main.eclipse))
            {
                return SceneEffectPriority.Environment;
            }

            return SceneEffectPriority.BiomeHigh;
        }
    }
    protected override bool ConfigValue => CTMConfig.Instance().AstralInfection;
    protected override string MusicSlot => CTMUtil.AstralInfection;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAstral;
}