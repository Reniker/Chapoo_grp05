using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapoo_grp05.Model
{
    class Bestelling
    {
        public int id;
        public string naam;
        public float prijs;
        public int tafelNummer;

        public Bestelling(int id, string naam, float prijs, int tafelNummer)
        {
            this.id = id;
            this.naam = naam;
            this.prijs = prijs;
            this.tafelNummer = tafelNummer;
        }
    }
}
