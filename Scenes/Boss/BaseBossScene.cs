using Terraria;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public abstract class BaseBossScene : ModSceneEffect
{
    protected abstract bool ConfigValue { get; }
    protected abstract int BossID { get; }
    protected abstract string MusicSlot { get; }

    public override int Music => CTMUtil.GetMusicSlot(MusicSlot);

    public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

    public override float GetWeight(Player player)
    {
        return 0.6f;
    }

    public override bool IsSceneEffectActive(Player player)
    {
        return ConfigValue && NPC.AnyNPCs(BossID);
    }
}