//todo
// fazer um método para mostrar progresso de outro método ( barra de progresso ou algo assim, limpa a tela mostra um texto e a barra toda vez que chamado)
class Program
{
    static Dictionary<int, string[]> person_data = new Dictionary<int, string[]>();
    static string[] temp = [];

    static void Main(string[] args)
    {   
        Main_menu();
    }

    static void Main_menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal");
        Console.WriteLine("1 - Gerenciar Cadastros");
        Console.WriteLine("2 - Ajuda");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Opção 1 - Gerenciar Cadastros");
                Manage_registers();
                break;
            case "2":
                Console.WriteLine("Opção 2 - Ajuda");
                Help();
                break;
            case "0":
                Console.WriteLine("sair");
                break;
            default:
                Console.WriteLine("Opção inválida");
                Main_menu();
                break;
        }
    }
    static void Help()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal > Ajuda");
        Console.WriteLine("Feito por @techopc");
        Console.WriteLine("Programa CLI basico para cadastro de pessoas (dados volateis)");
        Console.WriteLine("aperte 'Enter' para continuar.");
        switch (Console.ReadLine())
        {
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
        }
    }

    static void Manage_registers()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros");
        Console.WriteLine("1 - Adicionar Cadastro");
        Console.WriteLine("2 - Remover Cadastro");
        Console.WriteLine("3 - Alterar Cadastro");
        Console.WriteLine("4 - Visualizar Cadastro");
        Console.WriteLine("5 - Voltar para o Menu Principal");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("1 - Adicionar Cadastro");
                Add_register();
                break;
            case "2":
                Console.WriteLine("2 - Remover Cadastro");
                Remove_register();
                break;
            case "3":
                Console.WriteLine("3 - Alterar Cadastro");
                Edit_register();
                break;
            case "4":
                Console.WriteLine("4 - Visualizar Cadastro");
                Show_register();
                break;
            case "5":
                Console.WriteLine("5 - Voltar para o Menu Principal");
                Main_menu();
                break;
            default:
                Console.WriteLine("Opção inválida");
                Manage_registers();
                break;
        }
    }

    static void Add_register()
    {
        string input;
        int id;
        string name;
        string born_date;

        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros > Adicionar Cadastro > 1/2");
        Console.WriteLine("Digite o NOME do cadastro");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        input = Console.ReadLine();
        switch(input)
        {
            case "0":
                Console.WriteLine("0 - Voltar");
                Manage_registers();
                break;
            case "":
                Console.WriteLine("Opção inválida");
                Manage_registers();
                break;
        }
        name = input;
        Console.WriteLine("O nome é: " + input);
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros > Adicionar Cadastro > 2/2");
        Console.WriteLine("Digite a DATA DE NACIMENTO do cadastro (DD/MM/YYYY)");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        input = Console.ReadLine();
        switch(input)
        {
            case "0":
                Console.WriteLine("0 - Voltar");
                Manage_registers();
                break;
            case "":
                Console.WriteLine("Opção inválida");
                Manage_registers();
                break;
        }
        born_date = input;
        Console.WriteLine("A DATA é: " + input);
        Thread.Sleep(1000);
        Console.WriteLine("Salvando dados");
        id = person_data.Count;
        temp=[name,born_date];
        person_data.Add(id, temp);
        
        Console.Clear();
        Console.WriteLine("Dados Salvos");
        string[] data = person_data[key: id];
        Console.WriteLine("Name: " + data[0]);
        Console.WriteLine("Data de nacimento: " + data[1]);
        Thread.Sleep(2000);
        Main_menu();

    }

    static void Remove_register()
    {
        string input;
        int index;
        bool containsValue;
        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros > Remover Cadastro");
        Console.WriteLine("Digite o NOME do cadastro que queira remover.");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        input = Console.ReadLine();
        switch(input)
        {
            case "0":
                Console.WriteLine("0 - Voltar");
                Manage_registers();
                break;
            case "":
                Console.WriteLine("Opção inválida");
                Remove_register();
                break;
        }
        containsValue = false;
        index = 0;
        foreach (string[] value in person_data.Values)
        {
            if (value[0] == input)
            {
                containsValue = true;
                break;
            }
            else
            {
                index ++;
            }
        }
        if (containsValue)
        {
            string[] data = person_data[key: index];
            Console.WriteLine("Name: " + data[0]);
            Console.WriteLine("Data de nacimento: " + data[1]);
            Console.WriteLine("1 - Confirmar exclusão");
            Console.WriteLine("0 - Cancelar e voltar");
            Console.WriteLine("Digite uma opção e aperte 'Enter'");
            input = Console.ReadLine();
            switch(input)
            {
            case "1":
                Console.WriteLine("1 - Confirmar exclusão");
                person_data.Remove(index);
                Console.WriteLine("Exclusão confirmada");
                Manage_registers();
                break;
            case "0":
                Console.WriteLine("0 - Cancelar e voltar");
                Manage_registers();
                break;
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }
        }
        else
        {
            Console.WriteLine("Cadastro não encontrado.");
            Console.WriteLine("aperte 'Enter' para continuar.");
            input = Console.ReadLine();
            switch(input)
            {
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }
        }
    }
    
    static void Edit_register()
    {

        string input;
        int index;
        bool containsValue;
        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros > Editar Cadastro");
        Console.WriteLine("Digite o NOME do cadastro que queira editar.");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        input = Console.ReadLine();
        switch(input)
        {
            case "0":
                Console.WriteLine("0 - Voltar");
                Manage_registers();
                break;
            case "":
                Console.WriteLine("Opção inválida");
                Remove_register();
                break;
        }

        // Check if the dictionary contains a specific value
        containsValue = false;
        index = 0;
        foreach (string[] value in person_data.Values)
        {
            if (value[0] == input)
            {
                containsValue = true;
                break;
            }
            else
            {
                index ++;
            }
        }
        if (containsValue)
        {
            string[] data = person_data[key: index];
            Console.WriteLine("Name: " + data[0]);
            Console.WriteLine("Data de nacimento: " + data[1]);
            Console.WriteLine("1 - Editar NOME");
            Console.WriteLine("2 - Editar DATA");
            Console.WriteLine("0 - Cancelar e voltar");
            Console.WriteLine("Digite uma opção e aperte 'Enter'");
            input = Console.ReadLine();
            switch(input)
            {
            case "1":
                Console.WriteLine("1 - Editar NOME");
                Console.WriteLine("Digite o novo valor e aperte 'Enter'");
                Console.WriteLine("Para cancelar digite '0' e aperte 'Enter'");
                input = Console.ReadLine();
                switch(input)
                {
                    case "0":
                        Console.WriteLine("Edição cancelada");
                        Manage_registers();
                        break;
                    case "":
                        Console.WriteLine("saindo.");
                        Manage_registers();
                        break;
                    
                }
                data[0]= input;
                person_data[index]= [data[0],data[1]]; 
                Console.WriteLine("Edição confirmada");
                Manage_registers();
                break;
            case "2":
                Console.WriteLine("2 - Editar DATA");
                Console.WriteLine("Digite o novo valor e aperte 'Enter'");
                Console.WriteLine("Para cancelar digite '0' e aperte 'Enter'");
                input = Console.ReadLine();
                switch(input)
                {
                    case "0":
                        Console.WriteLine("Edição cancelada");
                        Manage_registers();
                        break;
                    case "":
                        Console.WriteLine("saindo.");
                        Manage_registers();
                        break;
                    
                }
                data[1]= input;
                person_data[index]= [data[0],data[1]]; 
                Console.WriteLine("Edição confirmada");
                Manage_registers();
                break;
            case "0":
                Console.WriteLine("0 - Cancelar e voltar");
                Manage_registers();
                break;
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }
        }
        else
        {
            Console.WriteLine("Cadastro não encontrado.");
            Console.WriteLine("aperte 'Enter' para continuar.");
            input = Console.ReadLine();
            switch(input)
            {
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }
        }
    }

    static void Show_register()
    {
        string input;
        int index;
        bool containsValue;
        Console.Clear();
        Console.WriteLine("Menu Principal > Gerenciamento de Cadastros > Visualizar Cadastro ");
        Console.WriteLine("Digite o NOME do cadastro para visualizar");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("Digite uma opção e aperte 'Enter'.");
        input = Console.ReadLine();
        switch(input)
        {
            case "0":
                Console.WriteLine("0 - Voltar");
                Manage_registers();
                break;
            case "":
                Console.WriteLine("Opção inválida");
                Show_register();
                break;
        }
        // Check if the dictionary contains a specific value
        containsValue = false;
        index = 0;
        foreach (string[] value in person_data.Values)
        {
            if (value[0] == input)
            {
                containsValue = true;
                break;
            }
            else
            {
                index ++;
            }
        }
        if (containsValue)
        {
            string[] data = person_data[key: index];
            Console.WriteLine("Name: " + data[0]);
            Console.WriteLine("Data de nacimento: " + data[1]);
            Console.WriteLine("aperte 'Enter' para continuar.");
            input = Console.ReadLine();
            switch(input)
            {
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }

        }
        else
        {
            Console.WriteLine("Cadastro não encontrado.");
            input = Console.ReadLine();
            switch(input)
            {
            default:
                Console.WriteLine("saindo.");
                Manage_registers();
                break;
            }
        }
    }
}



