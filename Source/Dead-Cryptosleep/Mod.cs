using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace FrontierDevelopments.DeadCryptosleep;

public class Mod : Verse.Mod
{
    public Mod(ModContentPack content) : base(content)
    {
        try
        {
            new Harmony("FrontierDevelopments.DeadCryptosleep").PatchAll(Assembly.GetExecutingAssembly());
        }
        catch (Exception e)
        {
            Log.Error($"Failed to load harmony patches: {e.Message}\n{e.StackTrace}");
        }
    }
}