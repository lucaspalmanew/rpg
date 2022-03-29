using System;

namespace POO
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            WriteOptions();
            var hero = short.Parse(Console.ReadLine());
            HandleMenuOption(hero);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("BEM VINDO AO RPG");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione um heroi abaixo");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione um heroi abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Guerreiro");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Mago");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3- Ninja");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Para sair digite a opção abaixo ");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("0- sair");

        }

        public static void HandleMenuOption(short hero)
        {
            switch (hero)
            {
                case 1: Heroes.Arus.Show(); break;
                case 2: Heroes.Jenica.Show(); break;
                case 3: Heroes.Wedge.Show(); break;
                case 0:

                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}