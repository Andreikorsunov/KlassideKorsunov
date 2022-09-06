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
        public double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double sissetulek = (tootasu - maksuvaba) * (tulumaks / 100);
            double nettopalk = tootasu - sissetulek;
            return nettopalk;
        }
    }
}
