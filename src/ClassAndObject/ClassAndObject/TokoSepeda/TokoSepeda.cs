using System;
using System.Globalization;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk;
        public string Tipe;
        public double Berat;
        public Sepeda(string Merk, string Tipe, double Berat)
        {
            this.Merk = Merk;
            this.Tipe = Tipe;
            this.Berat = Berat; 
        }
        public void TampilkanInformasi()
        {
            Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString("F1", CultureInfo.InvariantCulture)} kg");
        }
    }
}