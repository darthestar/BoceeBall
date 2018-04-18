using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoceeBall.Models
{
    public class Games
    {
        public int ID { get; set; }
        
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public DateTime Date {get;set;}
        public string Notes { get; set; }

        // games to a team
        public int? HomeTeamsID { get; set; }
        public int? AwayTeamsID { get; set; }
        public Teams Teams { get; set; }

    }
}
