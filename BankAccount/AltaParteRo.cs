using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    partial class Program
    {
        private static void RetrageNumerar()
        {
            Console.Clear();
            int[] optiuniRetragere = { 190, 250, 400, 700, 1000, 2000, 3000, 5000 };
            Console.WriteLine("Alegeti suma :");
            Console.WriteLine("< 1. 190                            1000  5. >");
            Console.WriteLine("< 2. 250                            2000  6. >");
            Console.WriteLine("< 3. 400                            3000  7. >");
            Console.WriteLine("< 4. 700                            5000  8. >");
            Console.WriteLine(" 9. Alta suma");

            var optiuniRetragereIndex = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (optiuniRetragereIndex)
            {
                case 1:
                    if (optiuniRetragere[1] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:190lei. Retrageti cardul");
                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 190;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(190);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;

                    }
                    break;
                case 2:
                    if (optiuniRetragere[2] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:250lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 250;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(250);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 3:
                    if (optiuniRetragere[3] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:400lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 400;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(400);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 4:
                    if (optiuniRetragere[4] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:700lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 700;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(700);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 5:
                    if (optiuniRetragere[5] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:1000lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 1000;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(1000);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 6:
                    if (optiuniRetragere[6] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:2000lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 2000;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(2000);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 7:
                    if (optiuniRetragere[7] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:3000lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 3000;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(3000);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 8:
                    if (optiuniRetragere[7] > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:5000lei. Retrageti cardul");

                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - 5000;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(5000);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                case 9:
                    Console.Write("Introduceti suma: ");
                    int altaSuma = Convert.ToInt32(Console.ReadLine());
                    if (altaSuma > soldCurent)
                    {
                        Console.WriteLine("Operatiune imposibila");
                    }
                    else
                    {
                        Console.WriteLine("Ati extras suma:{0} lei. Retrageti cardul", altaSuma);
                        Console.WriteLine("Nu plecati, urmeaza eliberarea banilor");
                        soldCurent = soldCurent - altaSuma;
                        File.WriteAllText(@"D:\VSProjects\Trainings\BankAccount\Sold.txt", soldCurent.ToString());

                        Console.WriteLine("Doriti un extras cont y/n ?");
                        var extras = Console.ReadLine();

                        if (extras.Equals("y"))
                        {
                            ExtrasCont(altaSuma);
                            Console.WriteLine("Extrasul a fost eliberat !");
                        }
                        else break;
                    }
                    break;
                default:
                    Console.WriteLine("Nu ati introdus cifra corecta. Introduceti un numar intre 1 si 9 !");
                    break;

            }
        }

        private static void ExtrasCont(int suma)
        {
            string[] lines = { "Extras de cont",
                "-----------------------------",
                "Ati extras suma:" + suma +" lei",
                "-----------------------------",
                DateTime.Now.ToString()
            };

            File.WriteAllLines(@"D:\VSProjects\Trainings\BankAccount\extras_cont.txt", lines);
        }

        private static void AlegeLimba()
        {
            Console.WriteLine("1. Romana");
            Console.WriteLine("2. Engleza");

            var limba = Convert.ToInt32(Console.ReadLine());

            switch (limba)
            {
                case 1:
                    OptiuniRomana();
                    break;
                case 2:
                    OptiuniEngleza();
                    break;
                default:
                    Console.WriteLine("Nu ati introdus ceva corect, introduceti 1 sau 2 !");
                    break;
            }
        }

        private static void OptiuniRomana()
        {
            Console.Clear();
            Console.WriteLine("1. Soldul cont");
            Console.WriteLine("2. Retrage numerar");

            var optiuni = Convert.ToInt32(Console.ReadLine());

            switch (optiuni)
            {
                case 1:
                    SoldCont();
                    break;
                case 2:
                    RetrageNumerar();
                    break;
                default:
                    Console.WriteLine("Nu ati introdus ceva corect, introduceti 1 sau 2 !");
                    break;
            }
        }

        private static void SoldCont()
        {
            Console.WriteLine("Soldul in cont este de : {0} lei", soldCurent);
        }
    }
}
