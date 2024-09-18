using System;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul;
        public string Penulis;
        public int TahunTerbit;
        public Buku(string Judul, String Penulis, int TahunTerbit)
        {
            this.Judul = Judul;
            this.Penulis = Penulis;
            this.TahunTerbit = TahunTerbit;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}

