using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PC
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int Space { get; set; }
        public int Frequency { get; set; }

        public PC(string model, string serialNumber, int space, int frequency)
        {
            Model = model;
            SerialNumber = serialNumber;
            Space = space;
            Frequency = frequency;
        }

        


    }
}
