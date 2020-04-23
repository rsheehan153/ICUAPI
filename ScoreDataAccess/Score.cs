using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreDataAccess
{
    class Score
    {
        public int score_id { get; set; }
        public int poid { get; set; }
        public int paidid { get; set; }
        public int mms_score { get; set; }
        public int cpa_total { get; set; }
        public int mrc_total { get; set; }
        public int sofa_total { get; set; }
        public string diagnosis { get; set; }
}
}
