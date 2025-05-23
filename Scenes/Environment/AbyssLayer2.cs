﻿using CalamityMod;
using Terraria;

namespace CalamityTouhouMusic.Scenes.Environment;

public class AbyssLayer2 : BaseEnvironmentScene
{
    protected override bool ConfigValue => CTMConfig.Instance().AbyssLayer2;
    protected override string MusicSlot => CTMUtil.AbyssLayers;

    public override bool SafeIsSceneEffectActive(Player player) => player.Calamity().ZoneAbyssLayer2;
}