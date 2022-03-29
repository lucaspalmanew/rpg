using System;
using POO.src.Entities;

namespace POO.Heroes
{
    public class Wedge
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("VOCÊ ESCOLHEU O HEROI WEDGE ");
            Console.WriteLine("");
            Console.WriteLine("");
            Options();
            var hero = short.Parse(Console.ReadLine());
            Start(hero);

        }
        public static void Options()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("PARA INFORMAÇÕES DE WEDGE DIGITE -1");
            Console.WriteLine("PARA ATACAR COM WEDGE DIGITE -2");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("PARA VOLTAR AO MENU DIGITE-3");
        }
        public static void Start(short hero)
        {

            var ninja = new Ninja();


            switch (hero)
            {
                case 1:
                    Console.Clear();
                    ninja.Name = "WEDGE";
                    ninja.Level = 20;
                    ninja.Hp = 180;

                    Console.WriteLine($"Name {ninja.Name} , Level {ninja.Level}, {ninja.Hp}");
                    Console.WriteLine("====================================================");
                    break;



                case 2:
                    Console.Clear();
                    Console.WriteLine("DIGITE UM VALOR DE PODER ");
                    var bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine(ninja.Attack(bonus));
                    Console.WriteLine($"PARABÉNS VOÇê RANCOU {bonus} DE HP DO INIMIGO");
                    Console.WriteLine("====================================================");
                    break;




                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Menu.Show(); break;
            }


        }

    }

}