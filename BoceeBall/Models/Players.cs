using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoceeBall.Models
{
    public class Players
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string PlayerNumber { get; set; }
        public string ThrowingArm { get; set; }

        //1 to many
        public int? TeamsID { get; set; }
        public Teams Teams { get; set; }
    }
}
