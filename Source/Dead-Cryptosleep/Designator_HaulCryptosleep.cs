using System;
using System.Linq;
using RimWorld;
using Verse;

namespace FrontierDevelopments.DeadCryptosleep;

public class Designator_HaulCryptosleep : Designator
{
    public Designator_HaulCryptosleep()
    {
        defaultLabel = "FrontierDevelopments.DeadCryptosleep.Designator.Label".Translate();
        defaultDesc = "FrontierDevelopments.DeadCryptosleep.Designator.Desc".Translate();
        icon = DeadCryptosleepDefOf.CryptosleepCasket.uiIcon;
        iconAngle = DeadCryptosleepDefOf.CryptosleepCasket.uiIconAngle;
        iconOffset = DeadCryptosleepDefOf.CryptosleepCasket.uiIconOffset;
        iconProportions =
            DeadCryptosleepDefOf.CryptosleepCasket.graphicData.drawSize.RotatedBy(DeadCryptosleepDefOf
                .CryptosleepCasket.defaultPlacingRot);
        iconDrawScale = GenUI.IconDrawScale(DeadCryptosleepDefOf.CryptosleepCasket);
    }

    public override DrawStyleCategoryDef DrawStyleCategory => DrawStyleCategoryDefOf.FilledRectangle;

    protected override DesignationDef Designation => DeadCryptosleepDefOf.Deadcryptosleep_Haul;

    private bool PodsAreAvailable()
    {
        var designated = Map.designationManager.AllDesignations
            .Count(designation => designation.def == DeadCryptosleepDefOf.Deadcryptosleep_Haul);

        var availableCaskets = Map.listerBuildings.allBuildingsColonist
            .Count(building => building is Building_CryptosleepCasket or Building_AncientCryptosleepCasket &&
                               !((Building_Casket)building).HasAnyContents);

        return availableCaskets >= designated;
    }

    public override AcceptanceReport CanDesignateCell(IntVec3 loc)
    {
        if (!loc.InBounds(Map) || loc.Fogged(Map))
        {
            return false;
        }

        try
        {
            CanDesignateThing(
                Map.thingGrid.ThingsListAt(loc)
                    .OfType<Corpse>()
                    .First());
            return true;
        }
        catch (InvalidOperationException)
        {
            return "FrontierDevelopments.DeadCryptosleep.Designator.NoCorpses".Translate();
        }
    }

    public override void DesignateSingleCell(IntVec3 c)
    {
        c.GetThingList(Map).OfType<Corpse>().ToList().ForEach(DesignateThing);
    }

    public override AcceptanceReport CanDesignateThing(Thing t)
    {
        if (t is Corpse)
        {
            return true;
        }

        return "FrontierDevelopments.DeadCryptosleep.Designator.MustBeCorpse".Translate();
    }

    public override void DesignateThing(Thing t)
    {
        if (CanDesignateThing(t).Accepted)
        {
            Map.designationManager.AddDesignation(new Designation((LocalTargetInfo)t, Designation));
        }
    }
}