using BepInEx;

namespace FilthMod.ModSupport
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    [BepInDependency(Plugin.PLUGIN_GUID, BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency(Vars.VRTRAKILL_GUID, BepInDependency.DependencyFlags.HardDependency)]
    public class VRTRAKILL_Support : BaseUnityPlugin
    {
        public const string
            PLUGIN_GUID = Plugin.PLUGIN_GUID + ".vrsupport",
            PLUGIN_NAME = "Filth Mod VR support",
            PLUGIN_VERSION = "1.0";

        public void Awake()
        {

        }
    }
}
