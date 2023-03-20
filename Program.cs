// See https://aka.ms/new-console-template for more information
using modul5_1302210070;

class MainProgram
{
    static void Main(string[] args)
    {
        Penjumlahan<long> jumlah = new Penjumlahan<long>();
        long a = 13;
        long b = 02;
        long c = 21;

        jumlah.JumlahTigaAngka(a, b, c);
        
        SimpleDataBase<long> database = new SimpleDataBase<long>();
        database.addNewData(13, DateTime.Now);
        database.addNewData(02, DateTime.Now);
        database.addNewData(21, DateTime.Now);
        
        database.printAllData();
    }
}
