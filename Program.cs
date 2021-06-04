using System;

namespace BA_C_SHARP_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Switch Case
            
            while (true)
            {

                Console.WriteLine("Trafik lambasi hangi renk yaniyor (red, yellow, green): ");
                string renk = Console.ReadLine();

                switch (renk)
                {
                    case "red":
                    case "kirmizi"
                        Console.WriteLine("DUR");
                        break;

                    case "yellow":
                    case "sari"
                        Console.WriteLine("HAZIRLAN");
                        break;

                    case "green":
                    case "yesil"
                        Console.WriteLine("GEC");
                        break;

                    default:
                        Console.WriteLine("Yanlis bir secim yaptiniz");
                        break;

                }

            }



           







        }
    }
}
