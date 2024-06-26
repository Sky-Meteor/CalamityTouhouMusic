﻿using System.ComponentModel;
using CalamityMod.NPCs.BrimstoneElemental;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityTouhouMusic;

public class CTMConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Boss")]
    [DefaultValue(true)]
    public bool DesertScourge;

    [DefaultValue(true)]
    public bool Crabulon;

    [DefaultValue(true)]
    public bool BrimstoneElemental;

    [DefaultValue(true)]
    public bool AstrumAureus;

    [DefaultValue(true)]
    public bool PlaguebringerGoliath;

    [DefaultValue(true)]
    public bool Ravager;

    [DefaultValue(true)]
    public bool StormWeaver;

    [Header("Biome")]
    [DefaultValue(true)]
    public bool SunkenSea;

    [DefaultValue(true)]
    public bool AbyssLayer1;

	[Header("Environment")]
    [DefaultValue(true)]
    public bool Blizzard;

    [Header("Misc")]
    [DefaultValue(TitleType.Title1)]
    [ReloadRequired]
    public TitleType Title;

    public bool EnableAll
    {
        get => AstrumAureus && BrimstoneElemental && Crabulon && DesertScourge && PlaguebringerGoliath && Ravager && StormWeaver && SunkenSea && AbyssLayer1 && Blizzard && Title != TitleType.Off;
        set
        {
            if (value)
            {
                AstrumAureus = true;
                BrimstoneElemental = true;
                Crabulon = true;
                DesertScourge = true;
                PlaguebringerGoliath = true;
                Ravager = true;
                StormWeaver = true;
                SunkenSea = true;
                AbyssLayer1 = true;
				Blizzard = true;
                if (Title == TitleType.Off)
                    Title = TitleType.Title1;
            }
        }
    }
    public bool DisableAll
    {
        get => !(AstrumAureus || BrimstoneElemental || Crabulon || DesertScourge || PlaguebringerGoliath || Ravager || StormWeaver || SunkenSea || AbyssLayer1 || Blizzard || Title != TitleType.Off);
        set
        {
            if (value)
            {
                AstrumAureus = false;
                BrimstoneElemental = false;
                Crabulon = false;
                DesertScourge = false;
                PlaguebringerGoliath = false;
                Ravager = false;
                StormWeaver = false;
                SunkenSea = false;
                AbyssLayer1 = false;
                Blizzard = false;
                Title = TitleType.Off;
            }
        }
    }

    public static CTMConfig Instance() => ModContent.GetInstance<CTMConfig>();
}