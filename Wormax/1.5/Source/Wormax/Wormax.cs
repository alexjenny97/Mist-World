using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;


namespace Wormax
{
    public class IngestionOutcomeDoer_RemoveHediff : IngestionOutcomeDoer
    {
        public IngestionOutcomeDoer_RemoveHediff() : base()
        {
        }
        public HediffDef removeThisThing;
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            if (ingestedCount > 0)
            {
                var gutwormsHediff = pawn.health.hediffSet.GetFirstHediffOfDef(removeThisThing);
                if (gutwormsHediff != null)
                {
                    pawn.health.hediffSet.hediffs.Remove(gutwormsHediff);
                }
            }
        }
    }
}
