using System;


namespace Ovning_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            Console.Title = "Kalkulator";
            Console.BackgroundColor = ConsoleColor.Magenta;
            // Jag ska göra en kalkulator som ska ha + - * /, jag börjar med en välkomstfras.

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nVälkommen till kalkuator");
            Console.WriteLine("\n-----------------------------------");
            string menyVal = "0";
            while (menyVal != "6")  // här kommer menyn
            {
             
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1.Räkna med +");
                Console.WriteLine("2.Räkna med -");
                Console.WriteLine("3.Räkna med *");
                Console.WriteLine("4.Räkna med /");
                Console.WriteLine("5.Se historik");
                Console.WriteLine("6.Avsluta");
                Console.WriteLine("\n-----------------------------------"); 
                // har valt att lägga till lite linjer för att göra min kalkulator lite snyggare
                menyVal = Console.ReadLine();

                switch (menyVal)   // Jag gör menyn med hjälp av case då jag tycker det blev enklast så
                {
                    case "1":
                        Console.WriteLine("Skriv in talen du vill räkna ut i addition,skriv talen på varsin rad");
                        double tal1 = double.Parse(Console.ReadLine());
                        double tal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{tal1}+{tal2}={tal1 + tal2}");
                        double resultTal = tal1 + tal2;// Detta är första menynvalet
                        list.Add(resultTal); 
                        break;


                    case "2":
                        Console.WriteLine("Skriv in talen du vill räkna ut subtraktion, skriv talen på varisn rad");
                        double sub1 = double.Parse(Console.ReadLine());
                        double sub2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{sub1}-{sub2}={sub1 - sub2}");
                        double resultSub = sub1 - sub2;
                        list.Add(resultSub);
                        break;

                    case "3":
                        Console.WriteLine("Skriv in talen du vill räkna ut för multiplikation, skriv talen på varsin rad");
                        double faktor1 = double.Parse(Console.ReadLine());
                        double faktor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{faktor1}*{faktor2}={faktor1 * faktor2}");
                        double resultFaktor = faktor1 + faktor2;
                        list.Add(resultFaktor);
                        break;


                    case "4":
                        Console.WriteLine("Skriv in talen du vill räkna ut i division,skriv talen på varsin rad");
                        double div1 = double.Parse(Console.ReadLine());
                        double div2 = double.Parse(Console.ReadLine());
                        if (div2 == 0)
                        {
                            Console.WriteLine("Inmatning fel, kan ej dela med 0"); 
                            // här fick jag använda mig av if satsen för att stoppa så att programmet inte går att dela med 0
                        }
                        else
                        {
                            double resultDiv = div1 / div2;
                            Console.WriteLine($"{div1}/{div2}={resultDiv}");
                            list.Add(resultDiv);
                        }

                        break;

                    case "5":
                        Console.WriteLine($"Historik:\n ");

                        foreach (double i in list)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine();

                        }
                        // Här fick jag använda mig av lista för att lagra historieken och i för att skriva ut den. 


                        break;


                    case "6":
                        Console.WriteLine("Programmet avslutas.");
                        break;
                        


                    default:
                        Console.WriteLine("Inmatning ogiltig, försök igen.");
                        break;
                }
               
            }
            // Jag försökte göra den så simppel som jag kunde för att jag själv skulle lära mig så mycket som möjligt med hjälp av mönstret och jag
            // börjar att se sammanhanget mellan de olika delarna.



           


        }
    }
}