using Terraria;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Environment;

public abstract class BaseEnvironmentScene : ModSceneEffect
{
    protected abstract bool ConfigValue { get; }
    protected abstract string MusicSlot { get; }

    public override int Music => CTMUtil.GetMusicSlot(MusicSlot);

    public override SceneEffectPriority Priority => SceneEffectPriority.Environment;

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