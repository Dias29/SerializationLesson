using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLib;
using System.IO;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> list = new List<PC>();
            string currentFile = @"D:\listSerial.txt";
           

            list.Add(new PC("Lenovo", "9982GHG6", 1000, 3.3));
            list.Add(new PC("Asus", "5452FHDJH4", 1000, 2.6));
            list.Add(new PC("HP", "DGd3436DGF", 500, 2.2));
            list.Add(new PC("Samsung", "12476YUWQ9", 500, 3.0));
            list.Add(new PC("iMac", "IIIII11111", 2000, 4.2));

            BinaryFormatter formatter = new BinaryFormatter();

            if (!File.Exists(currentFile))
            {
                using (FileStream stream = new FileStream(currentFile, FileMode.CreateNew))
                {
                    formatter.Serialize(stream, list.ToArray());
                }
            }
            else
            {
                using (FileStream stream = new FileStream(currentFile, FileMode.Create))
                {
                    formatter.Serialize(stream, list);
                }
                Console.WriteLine("Файл был перезаписан!");
            }

            Console.ReadLine();
        }
    }
}
