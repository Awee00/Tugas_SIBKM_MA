namespace Tugas.Kendaraan
{
    public class Kendaraan : AbstractKendaraan
    {
        //Constructor
        public Kendaraan()
        {
            Console.WriteLine("Membuat objek kendaraan");
        }

        public Kendaraan(string merek, string tipe, string warna ,int kapasitas, int power, int torsion)
        {
            this.merek = merek;
            this.tipe = tipe;
            this.warna = warna;
            this.kapasitas = kapasitas;
            this.power = power;
            this.torsion = torsion;
        }

        public override void Melaju()
        {
            Console.WriteLine($"{merek} {tipe} Melaju");
        }

        public override void Transmisi(int gear)
        {
            Console.WriteLine($"Transmisi pada gear {gear}");
        }

        public virtual void Tampilkan()
        {
            Console.WriteLine($"merek : {merek}");
            Console.WriteLine($"tipe : {tipe}");
            Console.WriteLine($"kapasitas : {kapasitas}cc");
            Console.WriteLine($"power : {power}hp");
            Console.WriteLine($"torsion : {torsion}N/m");
        }
    }
}
