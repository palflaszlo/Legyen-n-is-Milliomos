using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legyen_ön_is_Milliomos
{
    class Pontszam
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Highscore { get; set; }
        public int Id { get; set; }

        public Pontszam()
        {
            Id = new Random().Next(0, 10000);
        }

        public override string ToString()
        {
            var details = string.Format("{0} {1} {2} {3}", Id, FirstName, LastName, Highscore);
            return details;
        }
    }
}
