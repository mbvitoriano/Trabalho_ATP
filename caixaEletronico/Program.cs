using System;

namespace caixaEletronico {
    class Program {
        static void Main(string[] args) {

            /* Conta Corrente Comum (CCC) | Conta Corrente Com Cheque Especial (CCE)
            *Conta Poupança (CP) | Limites Conta Cheque especial (L1,L2,L3) */

            float ccc1, ccc2, ccc3, cce1, cce2, cce3, l1, l2, l3, cp1, cp2, cp3, contaSelecionada = 0;
            float valSaque, valDeposito, valPagamento, testeSaque, quantiaTransferencia, juroCheque, juroPoupanca, valAntig;
            int opcaoServico = 0, opcaoSaldo, opcaoSaque, opcaoDeposito, opcaoPagamento, opcaoTransferencia, contador = 0;

            /* Início das Operações */

            Console.WriteLine("Bem Vindo(a) ao terminal de caixa eletrônico do Banco C#!");

            Console.WriteLine("Para Iniciar, Informe o Saldo Disponível nas Contas Correntes: ");

            // Saldo conta corrente

            Console.Write("Saldo na Conta Corrente um: ");
            ccc1 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Corrente dois: ");
            ccc2 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Corrente três: ");
            ccc3 = float.Parse(Console.ReadLine());

            Console.Clear();

            // Saldo contas correntes com cheque especial

            Console.WriteLine("Informe o Saldo Disponível e o Limite nas Contas Correntes Com Cheque Especial: ");

            Console.Write("Saldo na Conta Corrente Com Cheque Especial um: ");
            cce1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o Limite disponível na conta: ");
            l1 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Corrente Com Cheque Especial dois: ");
            cce2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o Limite disponível na conta: ");
            l2 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Corrente Com Cheque Especial três: ");
            cce3 = float.Parse(Console.ReadLine());

            Console.Write("Informe o Limite disponível na conta: ");
            l3 = float.Parse(Console.ReadLine());


            Console.Clear();

            // Saldo conta poupança

            Console.WriteLine("Informe o Saldo Disponível nas Contas Poupança: ");

            Console.Write("Saldo na Conta Poupança um: ");
            cp1 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Poupança dois: ");
            cp2 = float.Parse(Console.ReadLine());

            Console.Write("Saldo na Conta Poupança três: ");
            cp3 = float.Parse(Console.ReadLine());

            Console.Clear();

            // Loop até que o usuário pare, digitando 6

            while (opcaoServico < 6) {
                Console.WriteLine("_____________________________________");
                Console.WriteLine();
                Console.WriteLine("Estes são os Serviços Disponíveis: ");
                Console.WriteLine("(1) - Consultar Saldo");
                Console.WriteLine("(2) - Efetuar um Saque");
                Console.WriteLine("(3) - Realizar um Depósito");
                Console.WriteLine("(4) - Efetuar um Pagamento");
                Console.WriteLine("(5) - Realizar uma Transferência");
                Console.WriteLine("(6) - Encerrar");

                Console.WriteLine("_____________________________________");
                Console.WriteLine();
                Console.Write("Digite uma opção: ");
                opcaoServico = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                // Teste para adicionar os juros

                if(opcaoServico == 1 || opcaoServico == 2 || opcaoServico == 3 || opcaoServico == 4 || opcaoServico == 5){

                    contador = contador + 1;

                    if(contador % 5 == 0){
                        
                        Console.Clear();

                        System.Console.Write(" # Antes de continuar, digite a taxa, em porcentagem, do juro do Cheque Especial: ");
                        juroCheque = int.Parse(Console.ReadLine());
                        System.Console.Write(" # Por gentileza digite a taxa, em porcentagem, do Rendimento da Poupança: ");
                        juroPoupanca = int.Parse(Console.ReadLine());

                        
                        // Juros para descontar o valor da utilização do cheque especial
                        if(l1 > cce1)
                        cce1 = cce1 + (cce1 * (juroCheque / 100));
                        else
                        System.Console.WriteLine("Seu saldo não pode ser maior que o limite");

                        if(l2 > cce2)
                        cce2 = cce2 + (cce2 * (juroCheque / 100));
                        else
                        System.Console.WriteLine("Seu saldo não pode ser maior que o limite");

                        if(l3 > cce3)
                        cce3 = cce3 + (cce3 * (juroCheque / 100));
                        else
                        System.Console.WriteLine("Seu saldo não pode ser maior que o limite");



                        // Juros para render a conta poupança
                        cp1 = cp1 + (cp1 * (juroPoupanca / 100));
                        cp2 = cp2 + (cp2 * (juroPoupanca / 100));
                        cp3 = cp3 + (cp3 * (juroPoupanca / 100));

                    }

                }

                /* Consulta de saldo */

                if (opcaoServico == 1) {
                    Console.WriteLine("Qual conta você deseja consultar? ");
                    Console.WriteLine("Contas cadastradas: ");

                    Console.WriteLine("(1) - Conta Corrente um.");
                    Console.WriteLine("(2) - Conta Corrente dois.");
                    Console.WriteLine("(3) - Conta Corrente três.");

                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                    Console.WriteLine("(7) - Conta Poupança um.");
                    Console.WriteLine("(8) - Conta Poupança dois.");
                    Console.WriteLine("(9) - Conta Poupança três.");

                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoSaldo = int.Parse(Console.ReadLine());

                    // Teste de opção da conta para consultar o saldo

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

                }


                /* Opção saque */


                else if (opcaoServico == 2) {
                    Console.WriteLine("De qual Conta Você Deseja Realiza o Saque?");
                    Console.WriteLine("Contas cadastradas: ");

                    Console.WriteLine("(1) - Conta Corrente um.");
                    Console.WriteLine("(2) - Conta Corrente dois.");
                    Console.WriteLine("(3) - Conta Corrente três.");

                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                    Console.WriteLine("(7) - Conta Poupança um.");
                    Console.WriteLine("(8) - Conta Poupança dois.");
                    Console.WriteLine("(9) - Conta Poupança três.");

                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoSaque = int.Parse(Console.ReadLine());

                    Console.Clear();

                    // Testes opção de saque por conta

                    if (opcaoSaque == 1) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc1 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            ccc1 = (ccc1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                            Console.WriteLine(" ");
                        }

                    } else if (opcaoSaque == 2) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc2 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            ccc2 = (ccc2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                            Console.WriteLine(" ");
                        }
                    } else if (opcaoSaque == 3) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = ccc3 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            ccc3 = (ccc3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                            Console.WriteLine(" ");
                        }
                    }

                      else if (opcaoSaque == 4) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce1 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cce1 = (cce1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce1);
                            Console.WriteLine(" ");
                        }
                    } else if (opcaoSaque == 5) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce2 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cce2 = (cce2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce2);
                            Console.WriteLine(" ");
                        }
                    } else if (opcaoSaque == 6) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cce3 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cce3 = (cce3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cce3);
                            Console.WriteLine(" ");
                        }
                    }


                      /* Conta Poupança*/


                      else if (opcaoSaque == 7) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp1);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp1 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cp1 = (cp1 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp1);
                            Console.WriteLine(" ");
                        }
                    } else if (opcaoSaque == 8) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp2);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp2 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cp2 = (cp2 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp2);
                            Console.WriteLine(" ");
                        }
                    } else if (opcaoSaque == 9) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp3);
                        Console.Write("Informe o Valor a ser Sacado: R$ ");
                        valSaque = float.Parse(Console.ReadLine());
                        testeSaque = cp3 - valSaque;
                        if (testeSaque < 0.0) {
                            Console.Clear();
                            Console.WriteLine("Operação Não Permitida, Saldo Insuficiente");
                            Console.WriteLine(" ");
                        } else {
                            cp3 = (cp3 - valSaque);
                            Console.Clear();
                            Console.WriteLine("Operação Efetuada com Sucesso! O novo Saldo é de R$ {0}", cp3);
                            Console.WriteLine(" ");
                        }
                    }
                }

                // Opção de depósito 

                else if (opcaoServico == 3) {
                    Console.WriteLine("De qual Conta Você Deseja Realiza o Depósito?");
                    Console.WriteLine("Contas cadastradas: ");

                    Console.WriteLine("(1) - Conta Corrente um.");
                    Console.WriteLine("(2) - Conta Corrente dois.");
                    Console.WriteLine("(3) - Conta Corrente três.");

                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                    Console.WriteLine("(7) - Conta Poupança um.");
                    Console.WriteLine("(8) - Conta Poupança dois.");
                    Console.WriteLine("(9) - Conta Poupança três.");

                    Console.Write("Escolha a Conta a Ser Consultada: ");
                    opcaoDeposito = int.Parse(Console.ReadLine());

                    Console.Clear();

                    // Testes para a opção de depósito

                    if (opcaoDeposito == 1) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc1 = (ccc1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 2) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc2 = (ccc2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 3) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        ccc3 = (ccc3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                        Console.WriteLine(" ");
                    }

                    // Conta Corrente com Cheque Especial

                    if (opcaoDeposito == 4) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce1 = (cce1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 5) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce2 = (cce2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 6) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cce3 = (cce3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce3);
                        Console.WriteLine(" ");
                    }

                    // Conta Poupança

                    if (opcaoDeposito == 7) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp1 = (cp1 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp1);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 8) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp2 = (cp2 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp2);
                        Console.WriteLine(" ");
                    }
                    if (opcaoDeposito == 9) {
                        Console.Write("Informe o Valor a ser Depositado: R$ ");
                        valDeposito = float.Parse(Console.ReadLine());
                        cp3 = (cp3 + valDeposito);
                        Console.Clear();
                        Console.WriteLine("Depósito Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp3);
                        Console.WriteLine(" ");
                    }
                }

                // Função de Pagamentos

                else if (opcaoServico == 4) {

                    valPagamento = 0; // Zerar o valor armazenado.

                    Console.WriteLine("Com Qual Conta Você Deseja Realizar o Pagamento?");
                    Console.WriteLine("Contas cadastradas: ");

                    Console.WriteLine("(1) - Conta Corrente um.");
                    Console.WriteLine("(2) - Conta Corrente dois.");
                    Console.WriteLine("(3) - Conta Corrente três.");

                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                    Console.WriteLine("(7) - Conta Poupança um.");
                    Console.WriteLine("(8) - Conta Poupança dois.");
                    Console.WriteLine("(9) - Conta Poupança três.");

                    Console.Write("Escolha a Conta a Ser Utilizada: ");
                    opcaoPagamento = int.Parse(Console.ReadLine());


                    Console.Clear();

                    // - Testes para opção de pagamentos com conta corrente

                    if (opcaoPagamento == 1) {

                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > ccc1) {
                                Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            ccc1 = (ccc1 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc1);
                            Console.WriteLine(" ");

                        }
                        
                    } else if (opcaoPagamento == 2) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                        

                        if (valPagamento > ccc2) {
                            Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            ccc2 = (ccc2 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc2);
                            Console.WriteLine(" ");

                        }
                    } else if (opcaoPagamento == 3) {
                        
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", ccc3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > ccc3) {
                            Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            ccc3 = (ccc3 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", ccc3);
                            Console.WriteLine(" ");

                        }
                    }

                      // Opção de pagamento com  Conta Corrente Com Cheque Especial

                      else if (opcaoPagamento == 4) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());
                    
                        if (valPagamento > cce1) {
                            if((cce1 + l1) >= valPagamento){
                                
                                valAntig = l1;
                                l1 = l1 - (valPagamento - cce1);
                                cce1 = cce1 - cce1;
                                cce1 = l1 - valAntig;
                                System.Console.WriteLine("Seu novo saldo é {0}, e possui um limite de {1}", cce1, l1);
                                

                            }else{
                                System.Console.WriteLine("Não há limite nem esse valor na sua conta.");
                            }
                        }  

                          else {

                            cce1 = (cce1 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce1);
                            Console.WriteLine(" ");

                        }
                    }
                     else if (opcaoPagamento == 5) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > cce2) {
                             if((cce2 + l2) >= valPagamento){
                                
                                valAntig = l2;
                                l2 = l2 - (valPagamento - cce2);
                                cce2 = cce2 - cce2;
                                cce2 = l2 - valAntig;
                                System.Console.WriteLine("Seu novo saldo é {0}, e possui um limite de {1}", cce2, l2);
                                

                            }else{
                                System.Console.WriteLine("Não há limite nem esse valor na sua conta.");
                            }
                        }  

                          else {

                            cce2 = (cce2 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce2);
                            Console.WriteLine(" ");
                        }
                    }


                      else if (opcaoPagamento == 6) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cce3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > cce3) {
                            if((cce3 + l3) >= valPagamento){
                                
                                valAntig = l3;
                                l3 = l3 - (valPagamento - cce3);
                                cce3 = cce3 - cce3;
                                cce3 = l3 - valAntig;
                                System.Console.WriteLine("Seu novo saldo é {0}, e possui um limite de {1}", cce3, l3);
                                

                            }else{
                                System.Console.WriteLine("Não há limite nem esse valor na sua conta.");
                            }
                        }  

                          else {

                            cce3 = (cce3 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cce3);
                            Console.WriteLine(" ");

                        }

                        // Pagamentos com conta poupança

                    } else if (opcaoPagamento == 7) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp1);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > cp1) {
                            Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            cp1 = (cp1 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp1);
                            Console.WriteLine(" ");

                        }
                    } else if (opcaoPagamento == 8) {

                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp2);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > cp2) {
                            Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            cp2 = (cp2 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp2);
                            Console.WriteLine(" ");

                        }
                    }else if (opcaoPagamento == 9) {
                        Console.WriteLine("O Saldo Disponínel na Conta Selecionada é R$ {0}", cp3);
                        Console.Write("Informe o Valor da Conta a ser Paga: R$ ");
                        valPagamento = float.Parse(Console.ReadLine());

                        if (valPagamento > cp3) {
                            Console.WriteLine("Impossível efetuar o pagamento. Utilize outra conta para realizar o pagamento.");
                        }  

                          else {

                            cp3 = (cp3 - valPagamento);
                            Console.WriteLine("Pagamento Efetuado com Sucesso! O novo Saldo é de R$ {0}", cp3);
                            Console.WriteLine(" ");

                        }
                }

                // Serviço de transferência do dinheiro.

                else if (opcaoServico == 5) {
                    Console.Clear();
                    Console.WriteLine("Com Qual Conta Você Deseja Realizar a transfêrencia?");
                    Console.WriteLine("Contas cadastradas: ");

                    Console.WriteLine("(1) - Conta Corrente um.");
                    Console.WriteLine("(2) - Conta Corrente dois.");
                    Console.WriteLine("(3) - Conta Corrente três.");

                    Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                    Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                    Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                    Console.WriteLine("(7) - Conta Poupança um.");
                    Console.WriteLine("(8) - Conta Poupança dois.");
                    Console.WriteLine("(9) - Conta Poupança três.");

                    Console.Write("Escolha a Conta a Ser Utilizada: ");
                    opcaoPagamento = int.Parse(Console.ReadLine());


                    Console.Clear();

                    // Testes para escolher a conta que será transferido o dinheiro

                    if (opcaoPagamento == 1) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente número um.");

                        Console.WriteLine("Para qual conta irá o dinheiro ?");
                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia em reais para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 2 && ccc1 >= quantiaTransferencia) {
                            Console.Clear();
                            ccc2 = ccc2 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && ccc1 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && ccc1 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && ccc1 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && ccc1 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && ccc1 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && ccc1 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && ccc1 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            ccc1 = ccc1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else if (opcaoPagamento == 2) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente número dois.");

                        Console.WriteLine("Para qual conta irá o dinheiro ?");
                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && ccc2 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && ccc2 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && ccc2 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && ccc2 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && ccc2 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && ccc2 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && ccc2 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && ccc2 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            ccc2 = ccc2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else if (opcaoPagamento == 3) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente número três.");

                        Console.WriteLine("Para qual conta irá o dinheiro ?");
                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia em reais para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && ccc3 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && ccc3 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && ccc3 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && ccc3 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && ccc3 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && ccc3 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && ccc3 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && ccc3 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            ccc3 = ccc3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else if (opcaoPagamento == 4) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente com cheque especial um");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia em reais para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cce1 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cce1 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cce1 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && cce1 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && cce1 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && cce1 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && cce1 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && cce1 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            cce1 = cce1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else if (opcaoPagamento == 5) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente com cheque especial dois");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia em reais para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cce2 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cce2 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cce2 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && cce2 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && cce2 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && cce2 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && cce2 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && cce2 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            cce2 = cce2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else if (opcaoPagamento == 6) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta corrente com cheque especial três");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um.");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia em reais para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cce3 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cce3 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cce3 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && cce3 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && cce3 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && cce3 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && cce3 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && cce3 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            cce3 = cce3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }


                    } else if (opcaoPagamento == 7) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta poupança um");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(8) - Conta Poupança dois.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cp1 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cp1 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cp1 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && cp1 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && cp1 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && cp1 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && cp1 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && cp1 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            cp1 = cp1 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }


                    } else if (opcaoPagamento == 8) {
                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta poupança dois");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(9) - Conta Poupança três.");

                        Console.Write("Digite para qual conta será feito a transferência:");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cp2 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cp2 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cp2 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && cp2 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && cp2 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && cp2 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && cp2 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 9 && cp2 >= quantiaTransferencia) {

                            cp3 = cp3 + quantiaTransferencia;
                            cp2 = cp2 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }

                    } else {

                        Console.Clear();
                        Console.WriteLine("O dinheiro será descontado da conta poupança três.");

                        Console.WriteLine("Contas cadastradas: ");

                        Console.WriteLine("(1) - Conta Corrente um.");
                        Console.WriteLine("(2) - Conta Corrente dois.");
                        Console.WriteLine("(3) - Conta Corrente três.");

                        Console.WriteLine("(4) - Conta Corrente Com Cheque Especial um");
                        Console.WriteLine("(5) - Conta Corrente Com Cheque Especial dois.");
                        Console.WriteLine("(6) - Conta Corrente Com Cheque Especial três.");

                        Console.WriteLine("(7) - Conta Poupança um.");
                        Console.WriteLine("(8) - Conta Poupança dois.");

                        Console.Write("Digite para qual conta será feito a transferência: ");
                        opcaoTransferencia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantia para ser transferida: ");
                        quantiaTransferencia = float.Parse(Console.ReadLine());

                        // Testes para fazer a transferência e verificar se há saldo disponível para essa operação

                        if (opcaoTransferencia == 1 && cp3 >= quantiaTransferencia) {

                            ccc1 = ccc1 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 2 && cp3 >= quantiaTransferencia) {

                            ccc2 = ccc2 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 3 && cp3 >= quantiaTransferencia) {

                            ccc3 = ccc3 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 4 && cp3 >= quantiaTransferencia) {

                            cce1 = cce1 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 5 && cp3 >= quantiaTransferencia) {

                            cce2 = cce2 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 6 && cp3 >= quantiaTransferencia) {

                            cce3 = cce3 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 7 && cp3 >= quantiaTransferencia) {

                            cp1 = cp1 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else if (opcaoTransferencia == 8 && cp3 >= quantiaTransferencia) {

                            cp2 = cp2 + quantiaTransferencia;
                            cp3 = cp3 - quantiaTransferencia;
                            Console.Clear();
                            Console.WriteLine("Tranferência realizada com sucesso.");

                        } else {
                            Console.Clear();
                            Console.WriteLine("Você não possui essa quantia para transferir ou não pode transferir para essa conta.");
                        }


                        }
                    }
                }
            }
        }
    }
}

