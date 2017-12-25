using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SerializationHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[] {
                new Person()
                {
                    FName = "Диас",
                    LName = "Уринбасаров",
                    PhoneNumber = "8700222020",
                    YearOfBirth = 1900
                },

                new Person()
                {
                    FName = "Азамат",
                    LName = "Бенгалин",
                    PhoneNumber = "87888888888",
                    YearOfBirth = 1999
                },

                new Person()
                {
                    FName = "Иван",
                    LName = "Еремов",
                    PhoneNumber = "870800000000",
                    YearOfBirth = 1988
                }


            };

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream stream = new FileStream(@"C:\name_of_directory\MyCsv.csv", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, person);
            }

            JsonSerializer json = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"c:\name_of_directory\json.txt")) 
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                json.Serialize(writer, person);
            }

            



            //Console.ReadLine();

        }
    }
}
