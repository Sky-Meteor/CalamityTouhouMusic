using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Scenes.Boss;

public class AnahitasLure : BaseBossScene
{
	public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
	protected override bool ConfigValue => CTMConfig.Instance().AnahitasLure;
	protected override int BossID => ModContent.NPCType<CalamityMod.NPCs.Leviathan.LeviathanStart>();
	protected override string MusicSlot => CTMUtil.AnahitasLure;
	public override int MusicDistance => 1600;
}