using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaStefanie = new ContaCorrente();

            contaDaStefanie.titular = "Stefanie";
            contaDaStefanie.agencia = 1234;
            contaDaStefanie.conta = 789;
            contaDaStefanie.saldo = 100.50;

            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "Joao";
            contaDoJoao.agencia = 1234;
            contaDoJoao.conta = 790;
            contaDoJoao.saldo = 120;

            Console.WriteLine("O titular da conta é:" + contaDaStefanie.titular);
            Console.WriteLine("O titular da conta é:" + contaDoJoao.titular);
        }
    }
}
