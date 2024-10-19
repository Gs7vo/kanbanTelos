using System;
using System.Collections.Generic;

class Program
{
    // Listas para as tarefas
    static List<string> afazer = new List<string>();
    static List<string> emProgresso = new List<string>();
    static List<string> concluido = new List<string>();

    static void Main(string[] args)
    {
        int opcao;
        do
        {
            // Exibição do menu principal
            Console.WriteLine("1 - Adicionar nova tarefa");
            Console.WriteLine("2 - Exibir tarefas");
            Console.WriteLine("3 - Mover tarefa");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ExibirTarefas();
                    break;
                case 3:
                    MoverTarefa();
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcao != 4);
    }

    // Método para adicionar uma nova tarefa à lista "A Fazer"
    static void AdicionarTarefa()
    {
        Console.Write("Digite o nome da tarefa: ");
        string tarefa = Console.ReadLine();
        afazer.Add(tarefa);
        Console.WriteLine($"Tarefa '{tarefa}' adicionada à lista 'A Fazer'.");
    }

    // Método para exibir as tarefas de cada lista
    static void ExibirTarefas()
    {
        Console.WriteLine("\nTarefas 'A Fazer':");
        ExibirLista(afazer);

        Console.WriteLine("\nTarefas 'Em Progresso':");
        ExibirLista(emProgresso);

        Console.WriteLine("\nTarefas 'Concluído':");
        ExibirLista(concluido);
    }

    // Método auxiliar para exibir uma lista
    static void ExibirLista(List<string> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa nesta lista.");
        }
        else
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lista[i]}");
            }
        }
    }

    // Metodo para mover tarefas entre as listras
    static void MoverTarefa()
    {
        Console.WriteLine("\nEscolha a lista de origem:");
        Console.WriteLine("1 - A Fazer");
        Console.WriteLine("2 - Em Progresso");
        Console.WriteLine("3 - Concluído");
        int origem = int.Parse(Console.ReadLine());

        List<string> listaOrigem = EscolherLista(origem);
        if (listaOrigem.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa disponível para mover.");
            return;
        }

        ExibirLista(listaOrigem);
        Console.Write("Escolha o número da tarefa para mover: ");
        int numTarefa = int.Parse(Console.ReadLine()) - 1;

        if (numTarefa < 0 || numTarefa >= listaOrigem.Count)
        {
            Console.WriteLine("Número de tarefa inválido.");
            return;
        }

        string tarefaMovida = listaOrigem[numTarefa];
        listaOrigem.RemoveAt(numTarefa);

        Console.WriteLine("\nEscolha o destino:");
        Console.WriteLine("1 - A Fazer");
        Console.WriteLine("2 - Em Progresso");
        Console.WriteLine("3 - Concluído");
        int destino = int.Parse(Console.ReadLine());

        List<string> listaDestino = EscolherLista(destino);
        listaDestino.Add(tarefaMovida);

        Console.WriteLine($"Tarefa '{tarefaMovida}' movida com sucesso.");
    }

    // Metodo para selecionar a lista de acordo com a escolha
    static List<string> EscolherLista(int opcao)
    {
        switch (opcao)
        {
            case 1:
                return afazer;
            case 2:
                return emProgresso;
            case 3:
                return concluido;
            default:
                Console.WriteLine("Opção inválida.");
                return null;
        }
    }
}
