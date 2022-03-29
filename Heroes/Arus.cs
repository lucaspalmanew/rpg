using System;
using POO.src.Entities;

namespace POO.Heroes
{
    public class Arus
    {
        public static void Show()
        {

            Console.WriteLine("===================================");
            Console.WriteLine("VOCê ESCOLHEU O HEROI ARUS ");
            Console.WriteLine("===================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Options();
            var hero = short.Parse(Console.ReadLine());
            Start(hero);

        }

        public static void Options()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("PARA INFORMAÇÕES DE ARUS DIGITE -1");
            Console.WriteLine("PARA ATACAR COM ARUS DIGITE -2 ");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("PARA VOLTAR AO MENU DIGITE-3");
        }
        public static void Start(short hero)
        {

            var kinight = new Kinight();


            switch (hero)
            {
                case 1:
                    Console.Clear();
                    kinight.Name = "Arus";
                    kinight.Level = 12;
                    kinight.Hp = 140;

                    Console.WriteLine($"Name {kinight.Name} , Level {kinight.Level} , Hp {kinight.Hp}");
                    Console.WriteLine("====================================================");
                    break;



                case 2:

                    Console.Clear();
                    Console.WriteLine("DIGITE UM VALOR DE PODER ");
                    var bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine(kinight.Attack(bonus));
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
