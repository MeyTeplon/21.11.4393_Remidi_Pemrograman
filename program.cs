using system;
namespace remidial;
{
    class program
    {
        static void Main (string[ ] args)
        {
            Dosen dosen1 = new Dosen();
            Dosen dosen2 = new Dosen();
            dosen2 attDosen(2, "Bayu Nadya Kusuma, S.T, M.Eng", 505028902, "Laki-laki");
            dosen1.print();
            dosen2.print();
        }
    }
}