using CalamityMod.MainMenu;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;

namespace CalamityTouhouMusic.Patch;

public class CalamityMainMenuPatch : ModSystem
{
    public override bool IsLoadingEnabled(Mod mod) => CTMConfig.Instance().Title != TitleType.Off;

    private Hook _hook;
    public override void Load()
    {
        _hook = new Hook(typeof(CalamityMainMenu).GetProperty("Music")?.GetMethod, GetMusic);
        _hook.Apply();
    }

    public override void Unload()
    {
        _hook.Dispose();
        _hook = null;
    }

    private static int GetMusic(CalamityMainMenu self) => CTMUtil.GetMusicSlot(CTMConfig.Instance().Title.ToString());
}