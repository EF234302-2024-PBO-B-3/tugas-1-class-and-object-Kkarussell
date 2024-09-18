using System;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk;
        public string Model;
        public int TahunProduksi;
        public Mobil(string Merk, string Model, int TahunProduksi)
        {
            this.Merk = Merk;
            this.Model = Model;
            this.TahunProduksi = TahunProduksi;
        }
        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}