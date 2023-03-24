namespace Tugas.Kendaraan
{
    public class Mobil : Kendaraan
    {
        private int Roda = 4;
        public string jenis { get; set; }

        //Constructor
        public Mobil() {
            Console.WriteLine("Membuat object mobil");
        }
        public Mobil(string merek, string tipe, string warna, int kapasitas, int power, int torsion, string jenis)
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
