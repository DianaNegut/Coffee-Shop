using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajati.Ferestre_Angajati
{
    public class Rezervare
    {
        public string IdRezervare { get; set; }
        public string OraRezervare { get; set; }
        public int NumarLocuri { get; set; }

        public DateTime DataRezervare { get; set; }
        public float IdMasa { get; set; }
    }
}
