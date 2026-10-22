using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;
using Verse.AI;

namespace FrontierDevelopments.DeadCryptosleep;

public class WorkGiver_HaulCryptosleep : WorkGiver_Scanner
{
    public override bool ShouldSkip(Pawn pawn, bool forced = false)
    {
        return !PotentialWorkThingsGlobal(pawn).Any();
    }

    public override IEnumerable<Thing> PotentialWorkThingsGlobal(Pawn pawn)
    {
        return pawn.Map.designationManager.AllDesignations
            .Where(designation => designation.def == DeadCryptosleepDefOf.Deadcryptosleep_Haul)
            .Select(designation => designation.target.Thing);
    }

    public override Job JobOnThing(Pawn pawn, Thing t, bool forced = false)
    {
        var pod = closestValidTarget(pawn, t);
        var corpse = t as Corpse;

        return new Job(DeadCryptosleepDefOf.HaulCorpseToCryptosleepCasket, corpse, pod)
        {
            count = 1
        };
    }

    private static Building_CryptosleepCasket closestValidTarget(Pawn pawn, Thing thing)
    {
        var map = pawn.Map;
        var position = thing.Position;
        return (Building_CryptosleepCasket)GenClosest.ClosestThingReachable(
            position,
            map,
            ThingRequest.ForGroup(ThingRequestGroup.BuildingArtificial),
            PathEndMode.ClosestTouch,
            TraverseParms.For(TraverseMode.PassDoors),
            validator: possibleThing => possibleThing is Building_CryptosleepCasket or Building_AncientCryptosleepCasket
                {
                    HasAnyContents: false
                } && pawn.CanReserveAndReach(new LocalTargetInfo(possibleThing), PathEndMode.ClosestTouch, Danger.None)
                  && pawn.CanReserveAndReach(new LocalTargetInfo(thing), PathEndMode.ClosestTouch, Danger.None));
    }
}