using System;
using System.Collections.Generic;
using System.IO;

namespace CSV_Danske_Postnumre
{
    class Program
    {
        static void Main(string[] args)
        {

          IDictionary<string, string> listPostNummer = new Dictionary<String, String>();

            using (var reader = new StreamReader(@"C:\Users\Jorgen\source\repos\CSV-Danske-Postnumre\danske-postnumre-byer-ny.csv"))
            {

                while(!reader.EndOfStream)
                {
                    
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                listPostNummer.Add(values[0], values[1]);

                }

            }

            Console.WriteLine("Enter the postnummer you want to view the town from");
            string postNumber = Console.ReadLine();
            //Opdaterer min value
            string value;
            //Tjekker om det eksisterer
            listPostNummer.TryGetValue(postNumber, out value);

            Console.Write(postNumber + " : " + value);



            


      









        }
    }
}
