using System.ComponentModel;
using CalamityMod.NPCs.BrimstoneElemental;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CalamityTouhouMusic;

public class CTMConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Boss")]
    [DefaultValue(true)]
    public bool AstrumAureus;

    [DefaultValue(true)]
    public bool BrimstoneElemental;

    [DefaultValue(true)]
    public bool Crabulon;

    [DefaultValue(true)]
    public bool DesertScourge;

    [DefaultValue(true)]
    public bool PlaguebringerGoliath;

    [DefaultValue(true)]
    public bool Ravager;

    [DefaultValue(true)]
    public bool StormWeaver;

    [Header("Biome")]
    [DefaultValue(true)]
    public bool SunkenSea;

    [Header("Environment")]
    [DefaultValue(true)]
    public bool Blizzard;

    [Header("Misc")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool Title;

    public bool EnableAll
    {
        get => AstrumAureus && BrimstoneElemental && Crabulon && DesertScourge && PlaguebringerGoliath && Ravager && StormWeaver && SunkenSea && Blizzard && Title;
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
                Blizzard = true;
                Title = true;
            }
        }
    }
    public bool DisableAll
    {
        get => !(AstrumAureus || BrimstoneElemental || Crabulon || DesertScourge || PlaguebringerGoliath || Ravager || StormWeaver || SunkenSea || Blizzard || Title);
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
                Blizzard = false;
                Title = false;
            }
        }
    }

    public static CTMConfig Instance() => ModContent.GetInstance<CTMConfig>();
}