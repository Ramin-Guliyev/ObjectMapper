using System;

namespace ObjectMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker() {
                Id = 5,
                Name="Ramin",
                Age = 21,
                Salary= 1600
            };
            var person = ObjectMapper.Mapper.Map<Worker, Person>(worker);

            Console.WriteLine($"After mapping: The person is  {person.Name} age : {person.Age}");
            Console.ReadLine();
        }
    }
}
