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
                //Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(V2))] internal class VTwo
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(V2.Start))] static void RemoveArms(V2 __instance)
            {
                Transform[] T;
                if (__instance.secondEncounter)
                    T = new Transform[]
                    {
                        __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0),
                        __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(1)
                    };
                else
                    T = new Transform[]
                    {
                        __instance.transform.GetChild(4).GetChild(3).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0),
                        __instance.transform.GetChild(4).GetChild(3).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(1)
                    };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "F2";
                Patches.RemoveArms(T);
            }
        }


        // stray, schism, soldier
        [HarmonyPatch(typeof(ZombieProjectiles))] internal class SSS
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(ZombieProjectiles.Start))] static void RemoveArms(ZombieProjectiles __instance)
            {
                Transform[] T;
                switch (__instance.GetComponent<EnemyIdentifier>().fullName)
                {
                    case "Stray":
                        {
                            // PZ(Clone)/zombierig/Armature.001/Base/Hips/Chest/Shoulder (L/R)
                            T = new Transform[]
                            {
                                __instance.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(1),
                                __instance.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(2)
                            };
                            break;
                        }
                    case "Schism":
                        {
                            T = new Transform[]
                            {
                                __instance.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(1),
                                __instance.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(2),
                                __instance.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(3)
                            };
                            break;
                        }
                    case "Soldier":
                        {
                            T = new Transform[]
                            {
                                __instance.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetChild(0),
                                __instance.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetChild(1)
                            };
                            break;
                        }
                    default: return;
                }
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filth";
                try { Patches.RemoveArms(T); } catch {}
            }
        }
        [HarmonyPatch(typeof(Stalker))] internal class Stakler
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Stalker.Start))] static void RemoveArms(Stalker __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(2).GetChild(1).GetChild(0),
                    __instance.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(2).GetChild(1).GetChild(1)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filther";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Sisyphus))] internal class Insurrectionist
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Sisyphus.Start))] static void RemoveArms(Sisyphus __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0)
                                        .GetChild(0).GetChild(0).GetChild(0).GetChild(0),
                    __instance.transform.GetChild(2)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthiphean Insurrectionist";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Ferryman))] internal class Furryman
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Ferryman.Start))] static void RemoveArms(Ferryman __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(2).GetChild(4).GetChild(0).GetChild(2),
                    __instance.transform.GetChild(0).GetChild(1).GetChild(1).GetChild(0).GetChild(3),
                    __instance.transform.GetChild(0).GetChild(3)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthman";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(SwordsMachine))] internal class SM
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(SwordsMachine.Start))] static void RemoveArms(SwordsMachine __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(1),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(1),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(2).GetChild(1),
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Disarmed Swordsmachine";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Streetcleaner))] internal class Streetwiper
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Streetcleaner.Start))] static void RemoveArms(Streetcleaner __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(1).GetChild(6).GetChild(0).GetChild(0).GetChild(0),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(1).GetChild(6).GetChild(0).GetChild(0).GetChild(1)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthcleaner";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Mindflayer))] internal class Motherfucker
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Mindflayer.Start))] static void RemoveArms(Mindflayer __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(5).GetChild(0).GetChild(0).GetChild(3),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(5).GetChild(0).GetChild(0).GetChild(4)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthflayer";
                Patches.RemoveArms(T);
            }
        }

        [HarmonyPatch(typeof(Mass))] internal class HideousMass
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Mass.Start))] static void RemoveArms(Mass __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(4),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(5)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filtheous Mass";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Gabriel))] internal class Gabe
        {

            [HarmonyPrefix] [HarmonyPatch(nameof(Gabriel.Start))] static void RemoveArms(Gabriel __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(1),
                    __instance.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(2),
                    __instance.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(3),
                    __instance.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(4)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Gabriel, Judge of Filth";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(GabrielSecond))] internal class Gabe2
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(GabrielSecond.Start))] static void RemoveArms(GabrielSecond __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(4).GetChild(5).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(1),
                    __instance.transform.GetChild(4).GetChild(5).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(2),
                    __instance.transform.GetChild(4).GetChild(5).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(3),
                    __instance.transform.GetChild(4).GetChild(5).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(4),
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Gabriel, Apostate of Filth";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(Mandalore))] internal class DruidKnight
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(Mandalore.Start))] static void RemoveArms(Mandalore __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(1),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(0).GetChild(2)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Flying Filth";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(MinosPrime))] internal class MeenosPrime
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(MinosPrime.Start))] static void RemoveArms(MinosPrime __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(0),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(1)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthos Prime";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(SisyphusPrime))] internal class SissyphusPrime
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(SisyphusPrime.Start))] static void RemoveArms(SisyphusPrime __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(8).GetChild(2).GetChild(0).GetChild(0).GetChild(0),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(8).GetChild(2).GetChild(0).GetChild(0).GetChild(1)
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "Filthiphus Prime";
                Patches.RemoveArms(T);
            }
        }
        [HarmonyPatch(typeof(MinosArm))] internal class CorpseArm
        {
            [HarmonyPostfix] [HarmonyPatch(nameof(MinosArm.Start))] static void FuckingDie(MinosArm __instance)
            => __instance.Retreat();
        }
        [HarmonyPatch(typeof(MinosBoss))] internal class Corpse
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(MinosBoss.Start))] static void RemoveArms(MinosBoss __instance)
            {
                Transform[] T =
                {
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(6).GetChild(2).GetChild(0),
                    __instance.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(6).GetChild(2).GetChild(1),
                };
                __instance.GetComponent<EnemyIdentifier>().overrideFullName = "The corpse of King Filthos";
                Patches.RemoveArms(T);
            }
        }

        [HarmonyPatch(typeof(BossHealthBar))] internal class HPBarChanger
        {
            [HarmonyPrefix] [HarmonyPatch(nameof(BossHealthBar.Awake))] static void Awake(BossHealthBar __instance)
            => __instance.bossName = null;
        }

        private static void RemoveArms(Transform[] Transformers)
        {
            if (Transformers.Length != 0)
                foreach (Transform T in Transformers)
                {
                    T.localScale = Vector3.zero;
                    T.gameObject.SetActive(false);
                }
        }
    }
}
