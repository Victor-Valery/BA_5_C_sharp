using System;

namespace BA_C_SHARP_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Switch Case
            
            Console.WriteLine("Trafik lambasi hangi renk yaniyor (red, yellow, green): ");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "red": Console.WriteLine("DUR");
                    break;

                case "yellow":
                    Console.WriteLine("HAZIRLAN");
                    break;

                case "green":
                    Console.WriteLine("GEC");
                    break;

                default:
                    break;

            }








        }
    }
}
