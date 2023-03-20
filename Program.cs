// See https://aka.ms/new-console-template for more information
using modul5_1302210070;

class MainProgram
{
    static void Main(string[] args)
    {
        SimpleDataBase<long> database = new SimpleDataBase<long>();
        database.addNewData(13, DateTime.Now);
        database.addNewData(02, DateTime.Now);
        database.addNewData(21, DateTime.Now);
        
        database.printAllData();

    }
}
