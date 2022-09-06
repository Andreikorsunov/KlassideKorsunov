using System;

namespace KlassideKorsunov
{
    internal class Kutsekooliopilane : Isik
    {
        public Kutsekooliopilane(string nimi, int synniAasta, sugu Sugu, string oppeasutus, string eriala, int kursus) : base(nimi, synniAasta, Sugu, oppeasutus, eriala, kursus) { }

        public Kutsekooliopilane(Kutsekooliopilane kutsekooliopilane)
        {
            this.nimi = kutsekooliopilane.nimi;
            this.synniAasta = kutsekooliopilane.synniAasta;
            this.Sugu = kutsekooliopilane.Sugu;
            this.oppeasutus = kutsekooliopilane.oppeasutus;
            this.eriala = kutsekooliopilane.eriala;
            this.kursus = kutsekooliopilane.kursus;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }

        public override void print_Haal()
        {
            throw new NotImplementedException();
        }

        public void muudaOppeAsutus(string uusAsutus)
        {
            this.oppeasutus = uusAsutus;
        }

        public void muudaEriala(string uusEriala)
        {
            this.eriala = uusEriala;
        }

        public void muudaKurs(int uusKurs)
        {
            this.kursus = uusKurs;
        }

        public override void print_Info()
        {
            Console.WriteLine($"\n{nimi} ta on {arvutaVanus()} aastat vana, ta on {Sugu}, õppisid {oppeasutus}, {eriala}, {kursus}");
        }
    }
}