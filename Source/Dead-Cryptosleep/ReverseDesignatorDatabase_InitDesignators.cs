using System.Collections.Generic;
using HarmonyLib;
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