using System.ComponentModel.DataAnnotations;

List<string> tarefas = new List<string>();

bool executar = true;
while (executar)
{
    Console.WriteLine("MENU:");
    Console.WriteLine("1- Criar");
    Console.WriteLine("2- Visualizar");
    Console.WriteLine("3- Editar");
    Console.WriteLine("4- Excluir");
    Console.WriteLine("5- Sair");

    Console.Write("Escolha uma opção: ");
    int.TryParse(Console.ReadLine(), out int opcao);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Criando...");
            Console.Write("Digite uma tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            break;
        case 2:
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Visualizando...");
                foreach (var t in tarefas)
                {
                    Console.WriteLine(t);
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }

            break;
        case 3:
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Editando...");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i} - {tarefas[i]}");
                }
                Console.Write("Escolha uma tarefa: ");
                int.TryParse(Console.ReadLine(), out int escolhaEditar);
                if (escolhaEditar >= 0 && escolhaEditar < tarefas.Count)
                {
                    Console.Write("Digite a nova tarefa: ");
                    tarefas[escolhaEditar] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Indice não existe!");
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            break;
        case 4:
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Excluindo...");
                foreach (var t in tarefas)
                {
                    Console.WriteLine(t);
                }
                Console.Write("Digite a tarefa a ser removida: ");
                string removerTarefa = Console.ReadLine();
                tarefas.Remove(removerTarefa);
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            break;
        case 5:
            executar = false;
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
    Console.WriteLine();
}
