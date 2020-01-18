using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //1. Mesajul de salut client
    //2. Autentificare, PIN - 4 cifre

    partial class Program
    {
        private static double soldCurent;

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt");
            soldCurent = Convert.ToDouble(text);
            //Mesajul de salut
            Console.WriteLine("****************************************************************");
            Console.WriteLine("--------------------Bun venit, stimat client!-------------------");
            Console.WriteLine("****************************************************************");

            //Autentificarea      

            if (Autentificare() == true)
            {
                Console.Clear();
                AlegeLimba();
            }
            else
            {
               if(Autentificare() == true)
               {
                    Console.Clear();

                    AlegeLimba();
               }
               else
               {
                    return;
               }
            }

            Console.ReadKey();
        }

        private static bool Autentificare()
        {
            int[] paroleValide = { 1234, 5789, 1001, 2345 };
            int count = 0;

           
            Console.Write("Introduceti PIN codul format din 4 cifre:");
            int parola = Convert.ToInt32(Console.ReadLine());
            //validare parola
            for (int i = 0; i < paroleValide.Length; i++)
            {
                count++;
                if (paroleValide[i] == parola)
                {
                    return true;
                }
                else if (count == paroleValide.Length)
                {
                    Console.WriteLine("Parola gresita!");
                    return false;
                }
            }

            return false;
        }                 
    }
}
