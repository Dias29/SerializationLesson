using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomeWork
{
    [Serializable]
    public class Person
    {
        public string FName{get;set;}
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public int YearOfBirth { get; set; }
    }
}
