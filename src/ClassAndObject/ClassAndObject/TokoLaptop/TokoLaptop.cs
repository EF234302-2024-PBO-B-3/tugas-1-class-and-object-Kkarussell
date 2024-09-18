using System;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk;
        public string Prosesor;
        public int Ram;
        public int Penyimpanan;
        public Laptop(string Merk, string Prosesor, int Ram, int Penyimpanan)
        {
            this.Merk = Merk;
            this.Prosesor = Prosesor;
            this.Ram = Ram;
            this.Penyimpanan = Penyimpanan;
        }
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}