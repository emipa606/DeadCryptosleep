using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace FrontierDevelopments.DeadCryptosleep;

[HarmonyPatch(typeof(ReverseDesignatorDatabase), "InitDesignators")]
internal static class ReverseDesignatorDatabase_InitDesignators
{
    public static void Postfix(List<Designator> ___desList)
    {
        var designator = new Designator_HaulCryptosleep();
        if (Current.Game.Rules.DesignatorAllowed(designator))
        {
            ___desList.Add(designator);
        }
    }
}

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