using System;
using POO.src.Entities;

namespace POO.Heroes
{
    public class Jenica
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("VOCê ESCOLHEU O HEROI JENICA");
            Console.WriteLine("===================================");
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
            Console.WriteLine("PARA INFORMAÇÕES DE JENICA DIGITE -1");
            Console.WriteLine("PARA ATACAR COM JENICA DIGITE-2");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("PARA VOLTAR AO MENU DIGITE-3");
        }
        public static void Start(short hero)
        {

            var wizard = new Wizard();


            switch (hero)
            {
                case 1:
                    Console.Clear();
                    wizard.Name = "JENICA";
                    wizard.Level = 22;
                    wizard.Hp = 200;

                    Console.WriteLine($"Name {wizard.Name} , Level {wizard.Level} , Hp {wizard.Hp}");
                    Console.WriteLine("====================================================");
                    break;



                case 2:
                    Console.Clear();
                    Console.WriteLine("DIGITE UM VALOR DE PODER ");
                    var bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine(wizard.Attack(bonus));
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
