using System;

namespace caixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Conta Corrente Comum (CCC) | Conta Corrente Com Cheque Especial (CCE)
            *Conta Poupança (CP) | Limites Conta Cheque especial (L1,L2,L3) */

            float ccc1, ccc2, ccc3, cce1, cce2, cce3, l1, l2, l3, cp1, cp2, cp3, contaSelecionada = 0;
            float valSaque, valDeposito, valPagamento, testePagamento, testeSaque;
            int opcaoServico = 0, opcaoSaldo, opcaoSaque, opcaoDeposito, opcaoPagamento;

            /* Início das Operações */

            Console.WriteLine("Bem Vindo(a) ao terminal de caixa eletrônico do Banco C#!");

            Console.WriteLine("Para Iniciar, Informe o Saldo Disponível nas Contas Correntes: ");
            Console.Write("Saldo na Conta Corrente 1: ");
            ccc1 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Corrente 2: ");
            ccc2 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Corrente 3: ");
            ccc3 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Informe o Saldo Disponível e o Limite nas Contas Correntes Com Cheque Especial: ");
            Console.Write("Saldo na Conta Corrente Com Cheque Especial 1: ");
            cce1 = float.Parse(Console.ReadLine());
            Console.Write("Informe o Limite disponível na conta: ");
            l1 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Corrente Com Cheque Especial 2: ");
            cce2 = float.Parse(Console.ReadLine());
            Console.Write("Informe o Limite disponível na conta: ");
            l2 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Corrente Com Cheque Especial 3: ");
            cce3 = float.Parse(Console.ReadLine());
            Console.Write("Informe o Limite disponível na conta: ");
            l3 = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Informe o Saldo Disponível nas Contas Poupança: ");
            Console.Write("Saldo na Conta Poupança 1: ");
            cp1 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Poupança 2: ");
            cp2 = float.Parse(Console.ReadLine());
            Console.Write("Saldo na Conta Poupança 3: ");
            cp3 = float.Parse(Console.ReadLine());

            Console.Clear();

            /* O uso do While no Menu garante que ele fique a mostra durante toda a utilização
             * até que o usuário pressione 6*/

            while (opcaoServico < 6)
            {
                Console.WriteLine("######################################");
                Console.WriteLine("Estes são os Serviços Disponíveis: ");
                Console.WriteLine("(1) - Consultar Saldo");
                Console.WriteLine("(2) - Efetuar um Saque");
                Console.WriteLine("(3) - Realizar um Depósito");
                Console.WriteLine("(4) - Efetuar um Pagamento");
                Console.WriteLine("(5) - Realizar uma Transferência");
                Console.WriteLine("(6) - Encerrar");
                Console.WriteLine("######################################");
                Console.WriteLine(" ");
                Console.Write("Escolha uma Opção: ");
                opcaoServico = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                /* Instruções a serem executadas no caso da opção escolhida ser Consulta ao Saldo */

                if (opcaoServico == 1)
                {
                    Console.WriteLine("Qual conta você deseja consultar? ");
                    Console.WriteLine("Contas cadastradas: ");
                    Console.WriteLine("(1) - Conta Corrente 1");
                    Console.WriteLine("(2) - Conta Corrente 2");
                    Console.WriteLine("(3) - Conta Corrente 3");
                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial 1");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial 2");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial 3");
                    Console.WriteLine("(7) - Conta Poupança 1");
                    Console.WriteLine("(8) - Conta Poupança 2");
                    Console.WriteLine("(9) - Conta Poupança 3");
                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoSaldo = int.Parse(Console.ReadLine());

                    if (opcaoSaldo == 1)
                        contaSelecionada = ccc1;
                    else if (opcaoSaldo == 2)
                        contaSelecionada = ccc2;
                    else if (opcaoSaldo == 3)
                        contaSelecionada = ccc3;
                    else if (opcaoSaldo == 4)
                        contaSelecionada = cce1;
                    else if (opcaoSaldo == 5)
                        contaSelecionada = cce2;
                    else if (opcaoSaldo == 6)
                        contaSelecionada = cce3;
                    else if (opcaoSaldo == 7)
                        contaSelecionada = cp1;
                    else if (opcaoSaldo == 8)
                        contaSelecionada = cp2;
                    else if (opcaoSaldo == 9)
                        contaSelecionada = cp3;

                    Console.Clear();
                    Console.WriteLine("O Saldo Disponível Nesta Conta é de R$ {0}", contaSelecionada);
                    Console.WriteLine(" ");
                }
                /* Instruções a serem executadas no caso da opção escolhida ser Saque */
                else if (opcaoServico == 2)
                {
                    Console.WriteLine("De qual Conta Você Deseja Realiza o Saque?");
                    Console.WriteLine("Contas cadastradas: ");
                    Console.WriteLine("(1) - Conta Corrente 1");
                    Console.WriteLine("(2) - Conta Corrente 2");
                    Console.WriteLine("(3) - Conta Corrente 3");
                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial 1");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial 2");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial 3");
                    Console.WriteLine("(7) - Conta Poupança 1");
                    Console.WriteLine("(8) - Conta Poupança 2");
                    Console.WriteLine("(9) - Conta Poupança 3");
                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoSaque = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.Clear();

                    /* Não sei se existe uma forma mais "compacta" de realizar essas operações, pois
                     * para cada operação é necessário verificar se o saque não seá maior do que o saldo disponível
                     * acredito que o modo utilizado na operação de consulta ao saldo não se aplica aqui.*/

                    if (opcaoSaque == 1)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc1 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc1 = (ccc1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                            Console.WriteLine(" ");
                        }

                    }
                    else if (opcaoSaque == 2)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc2 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc2 = (ccc2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoSaque == 3)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc3 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc3 = (ccc3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                            Console.WriteLine(" ");
                        }
                    }
                    /* Ainda não sei como o Limite de crédito será considerado nesse trabalho, acredito que, caso o saque
                     * seja maior do que o valor disponível, será utilizado o valor do cheque especial mas como levar isso
                     * em consideração mais pra frente, no caso dos cálculos de Juro sobre a utilização?.*/
                    else if (opcaoSaque == 4)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce1 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce1 = (cce1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce1);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoSaque == 5)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce2 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce2 = (cce2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoSaque == 6)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce3 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce3 = (cce3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce3);
                            Console.WriteLine(" ");
                        }
                    }
                    /* Conta Poupança*/
                    else if (opcaoSaque == 7)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp1 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp1 = (cp1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp1);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoSaque == 8)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp2 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp2 = (cp2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoSaque == 9)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp3 - valSaque;
                        if (testeSaque < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp3 = (cp3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp3);
                            Console.WriteLine(" ");
                        }
                    }
                }
                else if (opcaoServico == 3)
                {
                    Console.WriteLine("De qual Conta Você Deseja Realiza o Depósito?");
                    Console.WriteLine("Contas cadastradas: ");
                    Console.WriteLine("(1) - Conta Corrente 1");
                    Console.WriteLine("(2) - Conta Corrente 2");
                    Console.WriteLine("(3) - Conta Corrente 3");
                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial 1");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial 2");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial 3");
                    Console.WriteLine("(7) - Conta Poupança 1");
                    Console.WriteLine("(8) - Conta Poupança 2");
                    Console.WriteLine("(9) - Conta Poupança 3");
                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoDeposito = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.Clear();

                    if (opcaoDeposito == 1)
                    {                       
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc1 = (ccc1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 2)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc2 = (ccc2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 3)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc3 = (ccc3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                        Console.WriteLine(" ");
                    }
                    // Conta Corrente com Cheque Especial
                    if (opcaoDeposito == 4)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce1 = (cce1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 5)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce2 = (cce2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 6)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce3 = (cce3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce3);
                        Console.WriteLine(" ");
                    }
                    // Conta Poupança
                    if (opcaoDeposito == 7)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp1 = (cp1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 8)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp2 = (cp2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 9)
                    {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp3 = (cp3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp3);
                        Console.WriteLine(" ");
                    }
                }
                // Função de Pagamentos (Apenas repliquei a parte de saque pois a lógica é a mesma
                else if (opcaoServico == 4)
                {
                    Console.WriteLine("Com Qual Conta Você Deseja Realizar o Pagamento?");
                    Console.WriteLine("Contas cadastradas: ");
                    Console.WriteLine("(1) - Conta Corrente 1");
                    Console.WriteLine("(2) - Conta Corrente 2");
                    Console.WriteLine("(3) - Conta Corrente 3");
                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial 1");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial 2");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial 3");
                    Console.WriteLine("(7) - Conta Poupança 1");
                    Console.WriteLine("(8) - Conta Poupança 2");
                    Console.WriteLine("(9) - Conta Poupança 3");
                    Console.Write("Escolha a Conta a Ser Utilizada: ");
                    opcaoPagamento = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.Clear();
                    
                    if (opcaoPagamento == 1)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = ccc1 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc1 = (ccc1 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 2)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = ccc2 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc2 = (ccc2 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 3)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = ccc3 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            ccc3 = (ccc3 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                            Console.WriteLine(" ");
                        }
                    }
                    // Conta Corrente Com Cheque Especial
                    else if (opcaoPagamento == 4)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cce1 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce1 = (cce1 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce1);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 5)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cce2 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce2 = (cce2 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 6)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cce3 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cce3 = (cce3 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce3);
                            Console.WriteLine(" ");
                        }
                    }
                    // Conta Poupança
                    else if (opcaoPagamento == 7)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cp1 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp1 = (cp1 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp1);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 8)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cp2 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp2 = (cp2 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp2);
                            Console.WriteLine(" ");
                        }
                    }
                    else if (opcaoPagamento == 9)
                    {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        testePagamento = cp3 - valPagamento;
                        if (testePagamento < 0.0)
                        {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            cp3 = (cp3 - valPagamento);
                            Console.Clear();
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp3);
                            Console.WriteLine(" ");
                        }
                    }
                }
            }
        }
    }
}

