using Terraria.ModLoader;

namespace CalamityTouhouMusic;

public static class CTMUtil
{
    public const string MusicPath = "CalamityTouhouMusic/Assets/Music";
    public static int GetMusicSlot(string name) => MusicLoader.GetMusicSlot($"{MusicPath}/{name}");

    public const string DesertScourge = "DesertScourge";
    public const string AstrumAureus = "AstrumAureus";
    public const string PlaguebringerGoliath = "PlaguebringerGoliath";
    public const string Ravager = "Ravager";
    public const string BrimstoneElemental = "BrimstoneElemental";
    public const string Crabulon = "Crabulon";
    public const string StormWeaver = "StormWeaver";

    public const string SunkenSea = "SunkenSea";
    public const string AbyssLayer1 = "AbyssLayer1";

	public const string Blizzard = "Blizzard";

    public const string Title = "Title";
}