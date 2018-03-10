using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetADDReadeImageFromDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // путь к файлу для загрузки
            string filename = @"C:\Users\lhako\Pictures\hero.jpg";
            // заголовок файла
            string title = "Hero";
            SavingAndReading sr=new SavingAndReading();
            sr.SaveFileToDatabase(filename,title);
            sr.ReadFileFromDatabase();
        }
    }
}
