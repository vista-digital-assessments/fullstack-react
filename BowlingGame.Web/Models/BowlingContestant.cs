using BowlingGame.Core.Interfaces;
using BowlingGame.Web.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingGame.Web.Models
{
    public class BowlingContestant : IContestant
    {
        public bool IsInstanceComplete { get; set; }
        public string ContestantName { get; set; }
        public List<IScoreRecord> ScoringData { get; set; }

        public BowlingContestant()
        {
            ScoringData = new List<IScoreRecord>();
        }

        public int GetScore()
        {
            throw new NotImplementedException();
        }
    }
}
