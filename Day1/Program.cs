using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    enum Car
    {
        red,
        blue,
        green
    }

    class Program
    {
        static void MakeSpeak(ISpeakable animal)
        {
            animal.Speak();
        }

        static void Main(string[] args)
        {
            var austin = new Human();
            var wilkins = new Dog();

            MakeSpeak(wilkins);
            MakeSpeak(austin);

            var myDictionary = new Dictionary<string, string>();

            myDictionary.Add("Surface", "Microsoft");
            string myKey = myDictionary.FirstOrDefault(x => x.Value == "Microsoft").Key;
            Console.WriteLine(myDictionary["Surface"]);
            Console.WriteLine(myKey);

            var myEnumDictionary = new Dictionary<Car, int>();
            myEnumDictionary.Add(Car.red, 1);

            var conversionVals = new Dictionary<string, double>();
            conversionVals.Add("BTC", .0003);
            Console.WriteLine(5 * conversionVals["BTC"]);

            var humanDictionary = new Dictionary<string, Human>();
            humanDictionary.Add("austin", new Human("austin"));
            humanDictionary.Add("meagan", new Human("meagan"));
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (humanDictionary.Keys.Contains(username))
            {
                if (humanDictionary[username].password == password)
                {
                    Console.WriteLine("SUCCESSFUL LOGIN!");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
