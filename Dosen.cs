using system;
namespace remidial;
{
    class Dosen
    {
        private int id;
        private string nama;
        private int nik;
        private string gender;
        private string course;
        
        public Dosen()
        {
            id=1;
            nama = "Kamarudin, M.Kom";
            nik = 0525038203;
            gender ="Laki-laki";
            course="Pemrograman";
        }
        public void attDosen(int id, string name, int nik, string gender)
        {
            this.id=id;
            this.nama=name;
            this.nik=nik;
            this.gender=gender;
        }
        public void addCourse(string course)
        {
            this.course=course;
        }
        public void print()
        {
            Console.WriteLine($"Dosen ke-{this.id}");
            Console.WriteLine($"Nama       :{this.nama}");
            Console.WriteLine($"NIK           :{this.nik}");
            Console.WriteLine($"Gender    :{this.gender}");
            Console.WriteLine($"Course    :{this.course}");
        }
    }
}