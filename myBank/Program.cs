using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteThalia = new Gerente(){
                Nome = "Thalia",
                CPF = "456.465.540.22",
                Salario = 2000,
                NumeroDeAgencias = 5
            };

            gerenteThalia.Bonificacao = gerenteThalia.Salario;

            Vendedor vendedorNewton = new Vendedor(){
                Nome = "Newton",
                CPF = "123.123.123-23",
                Salario = 1000,
                NumeroClientesAtendidos = 2
            };

            vendedorNewton.Bonificacao = vendedorNewton.Salario;

            Vendedor vendedorCarol = new Vendedor(){
                Nome = "Carol",
                CPF = "456.456.456-56",
                Salario = 1000,
                NumeroClientesAtendidos = 4
            };

            vendedorCarol.Bonificacao = vendedorCarol.Salario;

            Vendedor vendedorDavi = new Vendedor(){
                Nome = "Davi",
                CPF = "789.789.789-89",
                Salario = 1000,
                NumeroClientesAtendidos = 3
            };

            vendedorDavi.Bonificacao = vendedorDavi.Salario;

            ContaCorrente contaDaStefanie = new ContaCorrente("Stefanie Barbosa Ancelmo", 1234, 120, vendedorDavi); //Davi
            ContaCorrente contaDaAnaJulia = new ContaCorrente("Ana Julia Barbosa", 1234, 100, vendedorCarol); //Carol
            ContaCorrente contaDaNathalia = new ContaCorrente("Nathalia Barbosa", 1234, 1500, vendedorNewton); //Newton

            Console.WriteLine("------------------------------------Contas------------------------------------");

            Console.WriteLine("O titular da conta é: "+contaDaStefanie.Titular);
            Console.WriteLine("O saldo da conta da Stefanie é: " + contaDaStefanie.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + vendedorDavi.Nome);
            Console.WriteLine("");
            Console.WriteLine("O titular da conta é: "+contaDaAnaJulia.Titular);
            Console.WriteLine("O saldo da conta da Ana Julia é: " + contaDaAnaJulia.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + vendedorCarol.Nome);
            Console.WriteLine("");
            Console.WriteLine("O titular da conta é: "+contaDaNathalia.Titular);
            Console.WriteLine("O saldo da conta da Nathalia é: " + contaDaNathalia.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + vendedorNewton.Nome);
            Console.WriteLine("");
            Console.WriteLine("Operações");
            Console.WriteLine("-------------------------------------Saque-------------------------------------");

            //Saque
            contaDaStefanie.Sacar(20);
            Console.WriteLine("Operação de saque, num valor de R$ 20,00");
            Console.WriteLine("O saldo atual da conta da Stefanie é: " + contaDaStefanie.Saldo);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------Transferência-------------------------------");
            
            //Trasferencia
            contaDaStefanie.Transferir(10, contaDaNathalia);
            Console.WriteLine("Operação de tranferência, num valor de R$ 10,00 - da Stefanie para a Nathalia.");
            Console.WriteLine("O saldo da conta da Stefanie é: " + contaDaStefanie.Saldo);
            Console.WriteLine("O saldo da conta da Nathalia é: " + contaDaNathalia.Saldo);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------Depósito----------------------------------");

            //Deposito
            contaDaAnaJulia.Depositar(50);
            Console.WriteLine("Operação de Despósito, num valor de R$ 50,00");
            Console.WriteLine("O saldo da conta da Ana Julia é: " + contaDaAnaJulia.Saldo);
            Console.WriteLine("");
            Console.WriteLine("------------------------------Saldo das Contas-----------------------------");
            
            Console.WriteLine("O saldo da conta da Stefanie é: " + contaDaStefanie.Saldo);
            Console.WriteLine("O saldo da conta da Ana Julia é: " + contaDaAnaJulia.Saldo);
            Console.WriteLine("O saldo da conta da Nathalia é: " + contaDaNathalia.Saldo);
            Console.WriteLine("");
            Console.WriteLine("---------------------------Comissão vendedores----------------------------");

            Console.WriteLine("A comissao do vendedor Newton é: " + vendedorNewton.Comissao);
            Console.WriteLine("A comissao da vendedora Carol é: " + vendedorCarol.Comissao);
            Console.WriteLine("A comissao do vendedor Davi é: " + vendedorDavi.Comissao);
            Console.WriteLine("Total de comissão a ser pago: " + ContaCorrente.TotalDeComissao);
            Console.WriteLine("");
            Console.WriteLine("------------------------------Bonificação Anual-----------------------------");

            Console.WriteLine("A bonificação do vendedor Newton é de: R$" + vendedorNewton.Bonificacao);
            Console.WriteLine("A bonificação da vendedora Carol é de: R$" + vendedorCarol.Bonificacao);
            Console.WriteLine("A bonificação do vendedor Davi é de: R$" + vendedorDavi.Bonificacao);
            Console.WriteLine("A bonificação da gerente Thalia é de: R$" + gerenteThalia.Bonificacao);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------Remuneração Total-----------------------------");
            
            Console.WriteLine("O vendedor Newton receberá R$" + vendedorNewton.RemuneracaoTotal(vendedorNewton.Salario, vendedorNewton.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A vendedora Carol receberá R$" + vendedorCarol.RemuneracaoTotal(vendedorCarol.Salario, vendedorCarol.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("O vendedor Davi receberá R$" + vendedorDavi.RemuneracaoTotal(vendedorDavi.Salario, vendedorDavi.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A gerente Thalia receberá R$" + gerenteThalia.RemuneracaoTotal(gerenteThalia.Salario, gerenteThalia.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------Férias----------------------------------");

            Console.WriteLine("A gerente Thalia terá " + gerenteThalia.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Newton terá " + vendedorNewton.CalcularFerias() + " dias de férias");
            Console.WriteLine("A vendedora Carol terá " + vendedorCarol.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Davi terá " + vendedorDavi.CalcularFerias() + " dias de férias");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------Total de Contas-----------------------------");

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
        }
    }
}