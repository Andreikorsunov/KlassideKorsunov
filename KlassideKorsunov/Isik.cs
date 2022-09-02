using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassideKorsunov
{
    abstract class Isik
    {
        protected string nimi;
        protected int synniAasta;
        public enum sugu { mees, naine };
        protected sugu Sugu;
        public Isik(string nimi, int synniAasta, sugu Sugu) 
        { 
            this.Sugu = Sugu;
        }
        public Isik(Isik isik)
        {
            this.nimi = isik.nimi;
            this.synniAasta = isik.synniAasta;
            this.Sugu = isik.Sugu;
        }
        public virtual void print_Info()
        {
            Console.Write("{nimi} sündinud {synniAasta} aastal, ja tema sugu on {sugu}");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaSynniAasta(int uusSynniAasta) { synniAasta = uusSynniAasta; }
        public void muudaSugu(sugu uusSugu) { Sugu = uusSugu; }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
    }
}