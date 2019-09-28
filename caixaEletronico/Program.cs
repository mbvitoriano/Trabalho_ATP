using System;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {

            // Conta Corrente Comum (CCC) | Conta Corrente Com Cheque Especial (CCE) | Conta Poupança (CP) | Limites Conta Cheque especial (L1,L2,L3)
            decimal ccc1, ccc2, ccc3, cce1, cce2, cce3, l1, l2, l3, cp1, cp2, cp3;
            int opcao = 0;
            Console.WriteLine("Bem Vindo(a) ao terminal de caixa eletrônico do Banco C#!");
            Console.WriteLine("Por gentileza, informe a operação desejada:");
            Console.WriteLine("(1) - Consultar Saldo");
            Console.WriteLine("(2) - Efetuar um Saque");
            Console.WriteLine("(3) - Realizar um Depósito");
            Console.WriteLine("(4) - Efetuar um Pagamento");
            Console.WriteLine("(5) - Realizar uma Transferência");
            Console.WriteLine("(6) - Encerrar");

        }
    }
}


