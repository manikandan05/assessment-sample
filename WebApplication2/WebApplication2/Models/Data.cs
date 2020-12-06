using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Threading.Tasks;

namespace WebApplication2.Models
{

    public class PhoneNumber
    {
        public int Number { get; set; }
    }

    public class Data
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<PhoneNumber> PhoneNumber { get; set; }

        public static List<Data> ResultData()
        {
            List<Data> result = new List<Data>();
            List<PhoneNumber> number = new List<PhoneNumber>();
            number.Add(new PhoneNumber { Number = 123567 });

            List<PhoneNumber> number1 = new List<PhoneNumber>();
            number1.Add(new PhoneNumber { Number = 123567 });
            number1.Add(new PhoneNumber { Number = 09876543 });

            result.Add(new Data { ID = 1, Name = "ABC", PhoneNumber = number });
            result.Add(new Data { ID = 2, Name = "xyz", PhoneNumber = number1 });
            result.Add(new Data { ID = 3, Name = "123", PhoneNumber = number });
            return result;
        }
    }
}
