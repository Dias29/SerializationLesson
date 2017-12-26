using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class PC
    {
        public string Bios { get; set; }
        public string MasterBootRecord { get; set; }
        public string PartitionBootSector { get; set; }
        public string Bootmgr { get; set; }

        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int Space { get; set; }
        public double Frequency { get; set; }

        public PC(string model, string serialNumber, int space, double frequency)
        {
            Model = model;
            SerialNumber = serialNumber;
            Space = space;
            Frequency = frequency;
        }

        public void Start()
        {
            Console.WriteLine("Включение компьютера");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  Запуск системы...");
            Thread.Sleep(1000);
            Console.WriteLine(Bios = "  Bios");
            Thread.Sleep(500);
            Console.WriteLine(MasterBootRecord = "  Master Boot Record");
            Thread.Sleep(500);
            Console.WriteLine(PartitionBootSector = "  Partition Boot Sector");
            Thread.Sleep(500);
            Console.WriteLine(Bootmgr = "  Bootmgr");
            Thread.Sleep(500);
            Console.ResetColor();
            Console.WriteLine("Компьютер включен!");
        }

        public void ShutDown()
        {
            Console.WriteLine("Выключение компьютера");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Thread.Sleep(1000);
            Console.WriteLine("  Сохранение файлов...");
            Thread.Sleep(500);
            Console.WriteLine("  Закрытие приложении...");
            Thread.Sleep(500);
            Console.WriteLine("  Отключение системы...");
            Thread.Sleep(500);
            Console.ResetColor();
            Console.WriteLine("Компьютер выключен!");
        }

        public void Restart()
        {
            ShutDown();
            Thread.Sleep(500);
            Start();
        }


    }
}
