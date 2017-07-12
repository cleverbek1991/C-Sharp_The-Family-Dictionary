using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family. Use the following example as a template`
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "BigBrother"},
                {"age", "1092"}
            });
            myFamily.Add("uncle", new Dictionary<string, string>(){
                {"name", "Beans"},
                {"age", "123"}
            });
            myFamily.Add("aunty", new Dictionary<string, string>(){
                {"name", "Anna"},
                {"age", "413"}
            });
            myFamily.Add("grandson", new Dictionary<string, string>(){
                {"name", "Pitbull"},
                {"age", "12"}
            });
            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old");
                // Krista is my sister and is 42 years old
            }
        }
    }
}
