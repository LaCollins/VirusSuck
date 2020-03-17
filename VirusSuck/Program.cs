using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            //add items one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");

            //remove items one at a time
            names.Remove("Stupidity");

            //remove via index
            names.RemoveAt(3);

            //add multiple items
            var people = new List<string> {"Nathan", "Martin", "Randy's Kid"};
            names.AddRange(people);
            //names.AddRange(new List<string> { "Nathan", "Martin", "Randy's Kid" });

            //remove multiple items
            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"Current name is {name}");
            }

            //----------------------------------------------------
            // Dictionaries
            //----------------------------------------------------

            var symptoms = new Dictionary<string, string>();

            // add single items
            symptoms.Add("COVID-19", "Dry cough, fever, respiratory distress");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            //get single thing
            var covidsymptoms = symptoms["COVID-19"];

            //remove single item
            symptoms.Remove("Ebola");

            //collection initializer
            var otherDictionary = new Dictionary<string, int> { { "Nathan", 33 }, { "Martin", 36 } };

            foreach (var (virus,symptom) in symptoms)
            {
                Console.WriteLine($"This {virus} virus has the following symptoms: {symptom}.");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"the {name} virus is unknown.");
                }
            }

            //--------------------------------------------
            // Queues
            //--------------------------------------------


        }
    }
}
