using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace softservetest
{
    class Program
    {
        static Petshop ps = new Petshop();

        static void Main(string[] args)
        {

            Menu();

        }

        public static void Menu()
        {
            Console.WriteLine("1 - add new animal");
            Console.WriteLine("2 - show all animals");

            switch(Console.ReadKey().KeyChar)
            {
                case '1':
                    {
                        Console.Clear();

                        Console.WriteLine("1 - dog");
                        Console.WriteLine("2 - cat");

                        switch(Console.ReadKey().KeyChar)
                        {
                            case '1':
                                {
                                    Console.Clear();

                                    Console.Write("Enter dog name: ");
                                    string name = Console.ReadLine();

                                    Console.Clear();

                                    Console.Write("Enter dog breed: ");
                                    string breed = Console.ReadLine();

                                    ps.addPet(new Dog(name, breed));

                                    Console.Clear();
                                    Menu();
                                }
                                break;

                            case '2':
                                {
                                    Console.Clear();

                                    Console.Write("Enter cat name: ");
                                    string name = Console.ReadLine();

                                    Console.Clear();

                                    Console.Write("Enter cat breed: ");
                                    string breed = Console.ReadLine();

                                    ps.addPet(new Cat(name, breed));

                                    Console.Clear();
                                    Menu();
                                }
                                break;
                        }
                    }
                    break;

                case '2':
                    {
                        Console.Clear();

                        ps.IntroduceAll();

                        Console.WriteLine("-------------");
                        Console.WriteLine("Press any key to return...");
                        char a = Console.ReadKey().KeyChar;

                        Console.Clear();

                        Menu();
                    }
                    break;
            }
        }
    }  
}
