using System;
using System.Collections.Generic;


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tempos = new List<int>();
            int tempo = 0;
            int pos = 0;
            int cont = 0;
            int opcao = 0;

            while (opcao != 12)
            {
                Console.WriteLine("MENU\n1) Inserir um tempo no início da lista\n2) Inserir um tempo no final da lista\n3) Inserir um tempo numa posição específica da lista\n4) Remover o primeiro tempo da lista(Imprimir o tempo removido)\n5) Remover o último tempo da lista(Imprimir o tempo removido)\n6) Remover um tempo de uma posição específica na lista(O usuário deve informar a posição do tempo a serremovido.Imprimir o tempo removido)\n7) Remover um tempo específico da lista(O usuário deve informar o tempo a ser removido)\n8) Pesquisar quantas vezes um determinado tempo consta na lista(O usuário deve informar o tempo a ser pesquisado)\n9) Mostrar todos os tempos da lista\n10) Mostrar todos os tempos da lista em ordem crescente\n11) Mostrar todos os tempos da lista em ordem decrescente\n12) Encerrar o programa\nDeseje a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o tempo que deseja inserir no inicio da fila: ");
                        tempo = int.Parse(Console.ReadLine());
                        tempos.Insert(0, tempo);
                        break;
                    case 2:
                        Console.WriteLine("Digite o tempo que deseja inserir no fim da fila:");
                        tempo = int.Parse(Console.ReadLine());
                        tempos.Add(tempo);
                        break;
                    case 3:
                        Console.WriteLine("Digite o tempo que deseja inserir: ");
                        tempo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a posição que deseja inseri-lo: ");
                        pos = int.Parse(Console.ReadLine());
                        tempos.Insert(pos, tempo);
                        break;
                    case 4:
                        Console.WriteLine("Primeiro tempo removido: " + tempos[0]);
                        tempos.RemoveAt(0);
                        break;
                    case 5:
                        cont = tempos.Count;
                        Console.WriteLine("Ultimo tempo removido: " + tempos[cont - 1]);
                        tempos.RemoveAt(cont - 1);
                        break;
                    case 6:
                        Console.WriteLine("Digite a posição da qual deseja remover o tempo: ");
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tempo removido: " + tempos[pos]);
                        tempos.RemoveAt(pos);
                        break;
                    case 7:
                        Console.WriteLine("Digite o tempo que deseja remover: ");
                        tempo = int.Parse(Console.ReadLine());
                        tempos.Remove(tempo);
                        break;
                    case 8:
                        Console.WriteLine("Digite o tempo que deseja pesquisar: ");
                        tempo = int.Parse(Console.ReadLine());
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            if (tempos[i] == tempo)
                            {
                                cont++;
                            }
                        }
                        Console.WriteLine("O tempo foi registrado " + cont + " vezes");
                        break;
                    case 9:
                        Console.WriteLine("<LISTA>");
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            Console.WriteLine(tempos[i]);
                        }
                        Console.WriteLine("<FIM DA LISTA>");
                        break;
                    case 10:
                        tempos.Sort();
                        Console.WriteLine("<LISTA>");
                        for (int i = 0; i < tempos.Count; i++)
                        {
                            Console.WriteLine(tempos[i]);
                        }
                        Console.WriteLine("<FIM DA LISTA>");
                        break;
                    case 11:
                        tempos.Sort();
                        Console.WriteLine("<LISTA>");
                        for (int i = tempos.Count - 1; i >= 0; i--)
                        {
                            Console.WriteLine(tempos[i]);
                        }
                        Console.WriteLine("<FIM DA LISTA>");
                        break;
                    case 12:
                        Console.WriteLine("FIM");
                        break;
                    default:
                        Console.WriteLine("Número invalido!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}