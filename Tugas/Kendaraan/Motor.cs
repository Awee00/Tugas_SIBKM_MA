namespace Tugas.Kendaraan
{
    class Motor : Kendaraan
    {
        private int Roda = 2;
        public string jenis { get; set; }

        public Motor()
        {
            Console.WriteLine("Membuat objek motor");
        }
        public Motor(string merek, string tipe, string warna, int kapasitas, int power, int torsion, string jenis)
                    : base(merek, tipe, warna, kapasitas, power, torsion)
        {
            this.jenis = jenis;
        }

        public override void Melaju()
        {
            Console.WriteLine($"{merek} {tipe} Melaju");
        }

        public override void Transmisi(int gear)
        {
            Console.WriteLine($"Transmisi pada gear {gear}");
        }

        public override void Tampilkan()
        {
            base.Tampilkan();
            Console.WriteLine($"Roda : {Roda}");
            Console.WriteLine($"Jenis : {jenis}");
        }
    }
}
