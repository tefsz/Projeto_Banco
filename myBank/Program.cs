using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaStefanie = new ContaCorrente("Stefanie", 1234, 789, 100.50);

            ContaCorrente contaDoJoao = new ContaCorrente("Joao", 1234, 790, 120);

            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 791, 150);

            Console.WriteLine("O titular da conta é:" + contaDaStefanie.titular);
            Console.WriteLine("O titular da conta é:" + contaDoJoao.titular);
            Console.WriteLine("O titular da conta é:" + contaDaMaria.titular);
        }
    }
}
