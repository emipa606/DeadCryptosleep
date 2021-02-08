using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace FrontierDevelopments.DeadCryptosleep
{
    public class Mod : Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("FrontierDevelopments.DeadCryptosleep");
            try
            {
                harmony.PatchAll(Assembly.GetExecutingAssembly());
            } catch(Exception e)
            {
                Log.Error("Failed to load harmony patches: " + e.Message + "\n" + e.StackTrace);
            }
        }
    }

    [StaticConstructorOnStartup]
    public class Resources
    {
        private const string name = "Things/Building/Ship/ShipCryptosleepCasket";
//        public static Material CryptosleepCasket = MaterialPool.MatFrom(name, ShaderDatabase.Transparent);
//        public static Texture2D CryptosleepCasket = ContentFinder<Texture2D>.Get(name);
    }
}