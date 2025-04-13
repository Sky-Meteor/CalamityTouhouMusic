using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public abstract class BaseBossScene : ModSceneEffect
{
    protected abstract bool ConfigValue { get; }
    protected abstract int BossID { get; }
    protected abstract string MusicSlot { get; }
    public virtual int MusicDistance => 5000;
    public virtual int[] AdditionalNPCs => new int[] { };

	public override int Music => CTMUtil.GetMusicSlot(MusicSlot);

    public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;

    public override float GetWeight(Player player)
    {
        return 0.6f;
    }

    public override bool IsSceneEffectActive(Player player) => SetSceneEffect(player);

    public virtual bool AdditionalCheck() => true;

    public virtual bool SetSceneEffect(Player player)
    {
	    if (!AdditionalCheck() || !ConfigValue)
		    return false;

	    Rectangle screenRect = new Rectangle((int)Main.screenPosition.X, (int)Main.screenPosition.Y, Main.screenWidth, Main.screenHeight);
	    int musicDistance = MusicDistance * 2;
	    foreach (NPC npc in Main.ActiveNPCs)
	    {
		    bool inList = false;
		    if (npc.type == BossID)
		    {
			    inList = true;
		    }
		    else
		    {
			    for (int i = 0; i < AdditionalNPCs.Length; i++)
			    {
				    if (npc.type == AdditionalNPCs[i])
				    {
					    inList = true;
					    break;
				    }
			    }
		    }

		    if (!inList)
			    continue;

		    Rectangle npcBox = new Rectangle((int)npc.Center.X - MusicDistance, (int)npc.Center.Y - MusicDistance, musicDistance, musicDistance);
		    if (screenRect.Intersects(npcBox))
			    return true;
	    }
	    return false;
    }
}