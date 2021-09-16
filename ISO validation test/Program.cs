using System;
using System.IO;
using Newtonsoft.Json;

namespace ISO_validation_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializedVariable = File.ReadAllText("/home/kamil/RiderProjects/ISO validation test/ISO validation test/CountryData_pretty.json");
            IsoDto isoDto = JsonConvert.DeserializeObject<IsoDto>(serializedVariable);

            Console.WriteLine(isoDto.Country.phone.phone_number_lengths == "USA");
        }
    }
}