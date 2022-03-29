using System;

namespace POO.src.Entities
{
    public class Kinight : Hero
    {

        public string Attack(int bonus)
        {

            if (bonus > 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return this.Name + "" + "" + "" + "LANÇOU UM ATAQUE SUPER EFETIVO COM BONUS DE " + bonus;

            }
            else
            {
                return this.Name + "" + "LANÇOU ATAQUE FRACO COM BONUS DE " + bonus;
            }
        }

    }
}