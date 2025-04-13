using System.ComponentModel;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityTouhouMusic.Scenes.Biome;
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
	public bool HiveMind;
	
	[DefaultValue(true)]
	public bool Perforators;

	[DefaultValue(true)]
	public bool AquaticScourge;

	[DefaultValue(true)]
	public bool BrimstoneElemental;
	
	[DefaultValue(true)]
	public bool Cryogen;
	
	[DefaultValue(true)]
	public bool AnahitasLure;

	[DefaultValue(true)]
	public bool AstrumAureus;

	[DefaultValue(true)]
	public bool PlaguebringerGoliath;

	[DefaultValue(true)]
	public bool Ravager;
	
	[DefaultValue(true)]
	public bool StormWeaver;

	[DefaultValue(true)]
	public bool CeaselessVoid;

	[DefaultValue(true)]
	public bool DevourerofGodsPhase1;

	[DefaultValue(true)]
	public bool DevourerofGodsPhase2;
	
	[Header("Biome")]
	[DefaultValue(true)]
	public bool SunkenSea;

	[DefaultValue(true)]
	public bool SulphurousSeaDay;

	[DefaultValue(true)]
	public bool SulphurousSeaNight;

	[DefaultValue(true)]
	public bool AbyssLayer1;

	[DefaultValue(true)]
	public bool AbyssLayer2;

	[DefaultValue(true)]
	public bool AbyssLayer3;

	[DefaultValue(true)]
	public bool AbyssLayer4;

	[DefaultValue(true)]
	public bool BrimstoneCrags;

	[DefaultValue(true)]
	public bool AstralInfection;

	[Header("Environment")]
	[DefaultValue(true)]
	public bool Blizzard;

	[DefaultValue(true)]
	public bool BioLab;

	[Header("Misc")]
	[DefaultValue(TitleType.Title1)]
	[DrawTicks]
	[ReloadRequired]
	public TitleType Title;

	public bool EnableAll
	{
		get => DesertScourge && Crabulon && HiveMind && Perforators && AquaticScourge && BrimstoneElemental && Cryogen && AnahitasLure && AstrumAureus && PlaguebringerGoliath && Ravager
		       && StormWeaver && CeaselessVoid && DevourerofGodsPhase1 && DevourerofGodsPhase2
		       && SunkenSea && SulphurousSeaDay && SulphurousSeaNight && AbyssLayer1 && AbyssLayer2 && AbyssLayer3 && AbyssLayer4 && BrimstoneCrags && AstralInfection
		       && Blizzard && BioLab && Title != TitleType.Off;
		set
		{
			if (value)
			{
				DesertScourge = true;
				Crabulon = true;
				HiveMind = true;
				Perforators = true;
				AquaticScourge = true;
				BrimstoneElemental = true;
				Cryogen = true;
				AnahitasLure = true;
				AstrumAureus = true;
				PlaguebringerGoliath = true;
				Ravager = true;
				StormWeaver = true;
				CeaselessVoid = true;
				DevourerofGodsPhase1 = true;
				DevourerofGodsPhase2 = true;
				SunkenSea = true;
				SulphurousSeaDay = true;
				SulphurousSeaNight = true;
				AbyssLayer1 = true;
				AbyssLayer2 = true;
				AbyssLayer3 = true;
				AbyssLayer4 = true;
				BrimstoneCrags = true;
				AstralInfection = true;
				Blizzard = true;
				BioLab = true;
				if (Title == TitleType.Off)
					Title = TitleType.Title1;
			}
		}
	}
	public bool DisableAll
	{
		get => !(DesertScourge || Crabulon || HiveMind || Perforators || AquaticScourge || BrimstoneElemental || Cryogen || AnahitasLure || AstrumAureus || PlaguebringerGoliath || Ravager
			|| StormWeaver || CeaselessVoid || DevourerofGodsPhase1 || DevourerofGodsPhase2
			|| SunkenSea || SulphurousSeaDay || SulphurousSeaNight || AbyssLayer1 || AbyssLayer2 || AbyssLayer3 || AbyssLayer4 || BrimstoneCrags || AstralInfection
			|| Blizzard || BioLab || Title != TitleType.Off);
		set
		{
			if (value)
			{
				DesertScourge = false;
				Crabulon = false;
				HiveMind = false;
				Perforators = false;
				AquaticScourge = false;
				BrimstoneElemental = false;
				Cryogen = false;
				AnahitasLure = false;
				AstrumAureus = false;
				PlaguebringerGoliath = false;
				Ravager = false;
				StormWeaver = false;
				CeaselessVoid = false;
				DevourerofGodsPhase1 = false;
				DevourerofGodsPhase2 = false;
				SunkenSea = false;
				SulphurousSeaDay = false;
				SulphurousSeaNight = false;
				AbyssLayer1 = false;
				AbyssLayer2 = false;
				AbyssLayer3 = false;
				AbyssLayer4 = false;
				BrimstoneCrags = false;
				AstralInfection = false;
				Blizzard = false;
				BioLab = false;
				Title = TitleType.Off;
			}
		}
	}

	public static CTMConfig Instance() => ModContent.GetInstance<CTMConfig>();
}