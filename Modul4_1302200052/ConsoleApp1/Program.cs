using System;
namespace Modul4_1302200052
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            // NIM = 1302200052
            Penjumlahan.JumlahTigaAngka<float>(13, 02, 20);
            SimpleDataBase<float> objData1 = new SimpleDataBase<float>();
            objData1.AddNewData(13f);
            objData1.AddNewData(02f);
            objData1.AddNewData(20f);
            objData1.PrintAllData();
        }
    }
}
