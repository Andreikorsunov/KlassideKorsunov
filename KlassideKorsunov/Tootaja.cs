using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static KlassideKorsunov.Isik;

namespace KlassideKorsunov
{
    internal class Tootaja
    {
        protected string asutus;
        protected string amet;
        protected double tootasu;
        public Tootaja(string asutus, string amet, double tootasu){}
        public Tootaja(Tootaja tootaja)
        {
            this.asutus = tootaja.asutus;
            this.amet = tootaja.amet;
            this.tootasu = tootaja.tootasu;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double sedaTeEiNae = (tootasu - maksuvaba) * (tulumaks / 100);
            double netopalk = tootasu - sedaTeEiNae;
            return netopalk;
        }
    }
}
