using HarmonyLib;
using RimWorld;

namespace FrontierDevelopments.DeadCryptosleep;

[HarmonyPatch(typeof(CompRottable), nameof(CompRottable.Active), MethodType.Getter)]
internal static class CompRottable_Active
{
    public static void Postfix(ref bool __result, CompRottable __instance)
    {
        if (!__result)
        {
            return;
        }

        if (__instance.parent.ParentHolder is Building_CryptosleepCasket or Building_AncientCryptosleepCasket)
        {
            __result = false;
        }
    }
}