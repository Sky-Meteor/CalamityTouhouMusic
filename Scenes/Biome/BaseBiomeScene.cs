using Terraria.ModLoader;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Biome;

public abstract class BaseBiomeScene : ModSceneEffect
{
    protected abstract bool ConfigValue { get; }
    protected abstract string MusicSlot { get; }

    public override int Music => CTMUtil.GetMusicSlot(MusicSlot);

    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;

    public override float GetWeight(Player player)
    {
        return 0.6f;
    }

    public sealed override bool IsSceneEffectActive(Player player)
    {
        return ConfigValue && SafeIsSceneEffectActive(player);
    }

    public virtual bool SafeIsSceneEffectActive(Player player)
    {
        return false;
    }
}