using BepInEx;
using HarmonyLib;

namespace FilthMod
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string
            PLUGIN_GUID = "com.whateverusername0.filthmod",
            PLUGIN_NAME = "Filth Mod",
            PLUGIN_VERSION = "1.0";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(System.Reflection.Assembly.GetExecutingAssembly(), $"{PLUGIN_GUID}.Patcher");
        }
    }
}
