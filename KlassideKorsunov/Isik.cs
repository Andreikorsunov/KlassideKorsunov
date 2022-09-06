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
        public string koolinimi;
        public string klass;
        public string specialsus;
        
        public string asutus;
        public string amet;
        public double tootasu;

        public string oppeasutus;
        public string eriala;
        public int kursus;
        public Isik(string nimi, int synniAasta, sugu Sugu, string kooliNimi, string klass, string specialsus)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.koolinimi = kooliNimi;
            this.klass = klass;
            this.specialsus = specialsus;
        }

        public Isik(string nimi, int synniAasta, sugu Sugu, string asutus, string amet, double tootasu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public Isik(string nimi, int synniAasta, sugu Sugu, string oppeasutus, string eriala, int kursus)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.Sugu = Sugu;
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
        }
        public Isik(Isik isik)
        {
            this.nimi = isik.nimi;
            this.synniAasta = isik.synniAasta;
            this.Sugu = isik.Sugu;
        }
        public virtual void print_Info()
        {
            Console.Write("{nimi} sündinud {synniAasta} aastal, ja ta on {Sugu}");
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