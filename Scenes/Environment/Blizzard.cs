using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

public class Blizzard : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().Blizzard;
    protected override string MusicSlot => CTMUtil.Blizzard;

    public override bool SafeIsSceneEffectActive(Player player)
    {
        return player.ZoneSnow && Main.raining && (Main.remixWorld ? player.ZoneRockLayerHeight : player.ZoneOverworldHeight);
    }
}