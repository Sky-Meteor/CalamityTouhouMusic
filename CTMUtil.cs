using Terraria.ModLoader;

namespace CalamityTouhouMusic;

public static class CTMUtil
{
    public const string MusicPath = "CalamityTouhouMusic/Assets/Music";
    public static int GetMusicSlot(string name) => MusicLoader.GetMusicSlot($"{MusicPath}/{name}");

    public const string DesertScourge = "DesertScourge";
    public const string Crabulon = "Crabulon";
	public const string HiveMind = "FilthyBlood";
    public const string Perforators = "FilthyBlood";
    public const string AquaticScourge = "AquaticScourge";
    public const string BrimstoneElemental = "BrimstoneElemental";
	public const string Cryogen = "Cryogen";
    public const string AnahitasLure = "AnahitasLure";
    public const string AstrumAureus = "AstrumAureus";
    public const string PlaguebringerGoliath = "PlaguebringerGoliath";
	public const string Ravager = "Ravager";
	public const string StormWeaver = "StormWeaver";
	public const string CeaselessVoid = "CeaselessVoid";
	public const string DevourerofGodsPhase1 = "DevourerofGodsPhase1";
	public const string DevourerofGodsPhase2 = "DevourerofGodsPhase2";

	public const string SunkenSea = "SunkenSea";
	public const string AbyssLayers = "AbyssLayers";
	public const string SulphurousSeaDay = "SulphurousSeaDay";
    public const string SulphurousSeaNight = "SulphurousSeaNight";
    public const string BrimstoneCrags = "BrimstoneCrags";
    public const string AstralInfection = "AstralInfection";

	public const string Blizzard = "Blizzard";
	public const string BioLab = "BioLab";

    public const string Title = "Title";
}