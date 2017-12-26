using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentFile = @"D:\listSerial.txt";

            BinaryFormatter formatter = new BinaryFormatter();
            List<PC> list = new List<PC>();

            using (FileStream stream = new FileStream(currentFile, FileMode.OpenOrCreate))
            {
                PC[] pc = formatter.Deserialize(stream) as PC[];
                foreach(var ch in pc)
                {
                    Console.WriteLine("Модель: {0}\nСерийный номер: {1}\nПамять: {2}\nЧастота: {3}", ch.Model, ch.SerialNumber, ch.Space, ch.Frequency);
                } 
            }

            Console.ReadLine();
        }
    }
}
