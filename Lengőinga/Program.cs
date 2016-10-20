//Kátai Antal Gergely 1. Beadandó házifeladat 2016/10/20 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lengőinga
{
    class Program
    {
        static char command;

        static void Main(string[] args)
        {
            //Képernyő törlése
            Console.Clear();  
            
            //Fejléc  
            hw_front();

            //Logic
            program();

            Console.ReadKey();
        }

        static void hw_front()
        {
            int i;
            var encoder = System.Text.Encoding.GetEncoding(437);
            var tl = new byte[] { 201 };
            var mid = new byte[] { 205 };
            var tr = new byte[] { 187 };
            var fg = new byte[] { 186 };
            var br = new byte[] { 188 };
            var bl = new byte[] { 200 };

            Console.Write("         {0}", (encoder.GetString(tl)));
            for (i = 0; i < 60; i++)
            {
                Console.Write("{0}", (encoder.GetString(mid)));
            }
            Console.Write("{0}", (encoder.GetString(tr)));

            Console.Write("\n         {0}                                                            {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                     Számítástechnika I.                    {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                                                            {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                    Féléves házi feladat                    {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                                                            {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                    Kátai Antal Gergely BFUQG7              {0}", (encoder.GetString(fg)));
            Console.Write("\n         {0}                                                            {0}", (encoder.GetString(fg)));

            Console.Write("                  {0}", (encoder.GetString(bl)));
            for (i = 0; i < 60; i++)
            {
                Console.Write("{0}", (encoder.GetString(mid)));
            }
            Console.Write("{0}", (encoder.GetString(br))); ;
            Console.Write("                               Kérem nyomja meg az ENTER gombot!");
        }

        static void program()
        {       
            //Menu    
            Console.WriteLine("\n---Fonálinga jellemzése---\n");
            Console.WriteLine("\nLengésidő..................T");
            Console.WriteLine("\nGyorsulás..................A");
            Console.WriteLine("\nFonal hossza...............L");
            Console.WriteLine("\nKilépés..................Q\n");
            do
            {
                Console.Write("\r\nKérem válasszon parancsot! ");
                command = Char.ToUpper(Convert.ToChar(Console.ReadLine())); // Nagybetű konverzó
            }
            while (command != 'T' && command != 'A' && command != 'L' && command != 'Q');

            //Elágazás a választott betű szerint
            switch (command)      
            {
                case 'T':                    
                    Console.WriteLine("\nLengésidő: {0:N2}s", countT());
                    break; 

                case 'A':
                    Console.WriteLine("\nÉrintő irányú gyorsulás: {0:N2}m/s^2", countA());
                    break;
                case 'L':
                    Console.WriteLine("\nFonalhossz: {0:N2}m", countL());
                    break;
                default:
                    break;
            }
            
            
        }

        static double countT()
        {
            Console.WriteLine("\nLengésidő kiszámítás: ");
            Console.Write("Fonalhossz(m): ");
            double l = Convert.ToDouble(Console.ReadLine());
            return 2 * 3.1415 * Math.Sqrt(l / 9.81);
        }

        static double countA()
        {
            Console.WriteLine("\nÉrintő irányú gyorsulás kiszámítása:");
            Console.Write("Szögelfordulás(rad): ");
            double fi = Convert.ToDouble(Console.ReadLine());
            return Math.Abs(9.81 * Math.Sin(fi));
            
        }

        static double countL()
        {
            Console.WriteLine("\nFonál hosszának kiszíámítása:");
            Console.Write("Lengési idő(s): ");
            double t = Convert.ToDouble(Console.ReadLine());
            return (t*t*9.81)/(4*3.1415*3.1415);

        }

    }
}
