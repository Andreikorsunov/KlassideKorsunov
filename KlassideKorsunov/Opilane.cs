using System;

namespace KlassideKorsunov
{
    internal class Opilane : Isik
    {
        public Opilane(string nimi, int synniAasta, sugu Sugu, string koolinimi, string klass, string spetsialsus) : base(nimi, synniAasta, Sugu, koolinimi, klass, spetsialsus) { }
        public Opilane(Opilane opilane)
        {
            this.nimi = opilane.nimi;
            this.synniAasta = opilane.synniAasta;
            this.Sugu = opilane.Sugu;
            this.koolinimi = opilane.koolinimi;
            this.klass = opilane.klass;
            this.spetsialsus = opilane.spetsialsus;
        }
        public override void print_Haal()
        {
            throw new NotImplementedException();
        }
        public override void print_Info()
        {
            Console.WriteLine($"\n{nimi} ta on {arvutaVanus()} aastat vana, ta on {Sugu}, õppisid {koolinimi}, {klass}, {spetsialsus}");
        }
        public void muudaKool(string uusKool)
        {
            this.koolinimi = uusKool;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }
    }
}