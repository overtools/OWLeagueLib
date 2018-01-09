using System;
using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class BaseMatch {
        public long ID { get; set; }

        public MatchState State { get; set; } = MatchState.Pending;
        public Competitor Winner { get; set; }
        public List<Competitor> Competitors { get; set; }
        public List<Score> Scores { get; set; }

        public Competitor Team1 => Competitors[0];
        public Competitor Team2 => Competitors[1];

        public DateTimeOffset StartDateTimeOffset() {
            return DateTimeOffset.FromUnixTimeMilliseconds(GetStartDate());
        }
        
        public DateTimeOffset EndDateTimeOffset() {
            return DateTimeOffset.FromUnixTimeMilliseconds(GetEndDate());
        }

        public virtual long GetStartDate() {
            return 0;
        }

        public virtual void SetStartDate(long value) { }

        public virtual long GetEndDate() {
            return 0;
        }

        public virtual void SetEndDate(long value) { }
    }

    // why are they different -_-
    public class Match : BaseMatch {
        public long EndDate { get; set; }
        public long StartDate { get; set; }

        public override long GetStartDate() {
            return StartDate;
        }

        public override void SetStartDate(long value) {
            StartDate = value;
        }

        public override long GetEndDate() {
            return EndDate;
        }

        public override void SetEndDate(long value) {
            EndDate = value;
        }
    }

    public class StageMatch : BaseMatch {
        public long EndDateTS { get; set; }
        public long StartDateTS { get; set; }

        public override long GetStartDate() {
            return StartDateTS;
        }

        public override void SetStartDate(long value) {
            StartDateTS = value;
        }

        public override long GetEndDate() {
            return EndDateTS;
        }

        public override void SetEndDate(long value) {
            EndDateTS = value;
        }
    }
}