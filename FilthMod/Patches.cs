using HarmonyLib;
using UnityEngine;

namespace FilthMod
{
    // a lot of enemies - a lot of boilerplate :(

    [HarmonyPatch] internal class Patches
    {
        [HarmonyPatch(typeof(Punch))] internal class VOne
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Punch.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(V2))] internal class VTwo
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(V2.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }

        // stray, schism, soldier
        [HarmonyPatch(typeof(ZombieProjectiles))] internal class SSS
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(ZombieProjectiles.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Stalker))] internal class Stakler
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Stalker.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Sisyphus))] internal class Insurrectionist
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Sisyphus.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Ferryman))] internal class Furryman
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Ferryman.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(SwordsMachine))] internal class SM
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(SwordsMachine.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Drone))] internal class Dron
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Drone.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Streetcleaner))] internal class Streetwiper
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Streetcleaner.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Mindflayer))] internal class Motherfucker
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Mindflayer.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Mass))] internal class HideousMass
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Mass.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Gabriel))] internal class Gabe
        {

            [HarmonyPrefix] [HarmonyPatch(nameof(Gabriel.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(GabrielSecond))] internal class Gabe2
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(GabrielSecond.Start))] static void RemoveArms()
            {
                Transform[] T =
                {

                };
                Patches.RemoveArms(T);
            }
        }

        private static void RemoveArms(Transform[] Transformers)
        {
            foreach (Transform T in Transformers)
                T.localScale = Vector3.zero;
        }
    }
}
