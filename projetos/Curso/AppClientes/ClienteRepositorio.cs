using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void GravarDadosClientes()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(clientes);

        File.WriteAllText("Clientes.txt", json);
    }

    public void LerDadosClientes()
    {
        if (File.Exists("Clientes.txt"))
        {
            var dados = File.ReadAllText("Clientes.txt");
            var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

        clientes.AddRange(clientesArquivo);
        }
        
    }

        public void ExcluirCliente()
    {
        Console.Clear();
        System.Console.WriteLine("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if (cliente == null)
        {
            System.Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        clientes.Remove(cliente);

        System.Console.WriteLine("Cliente removido com sucesso! [Enter]");

        Console.ReadKey();

    }

    public void EditarCliente()
    {
        Console.Clear();
        System.Console.WriteLine("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if (cliente == null)
        {
            System.Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        System.Console.WriteLine("Nome do cliente: ");

        var nome = System.Console.ReadLine();
        System.Console.WriteLine(Environment.NewLine);

        System.Console.WriteLine("Data de nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        System.Console.WriteLine(Environment.NewLine);

        System.Console.WriteLine("Desconto: ");
        var desconto = Decimal.Parse(Console.ReadLine());
        System.Console.WriteLine(Environment.NewLine);

        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        System.Console.WriteLine("Cliente editado com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();

    }

    public void CadastrarCliente()
    {
        Console.Clear();

        System.Console.WriteLine("Nome do cliente: ");
        var nome = System.Console.ReadLine();
        System.Console.WriteLine(Environment.NewLine);

        System.Console.WriteLine("Data de nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        System.Console.WriteLine(Environment.NewLine);

        System.Console.WriteLine("Desconto: ");
        var desconto = Decimal.Parse(Console.ReadLine());
        System.Console.WriteLine(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        clientes.Add(cliente);

        System.Console.WriteLine("Cliente cadastro com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void ImprimirCliente(Cliente cliente)
    {
        System.Console.WriteLine("ID.............: " + cliente.Id);
        System.Console.WriteLine("Nome...........: " + cliente.Nome);
        System.Console.WriteLine("Desconto.......: " + cliente.Desconto.ToString("0.00"));
        System.Console.WriteLine("Data Nascimento: " + cliente.DataNascimento);
        System.Console.WriteLine("Data Cadastro..: " + cliente.CadastradoEm);
        System.Console.WriteLine("-----------------------------------");
    }

    public void ExibirClientes()
    {
        Console.Clear();
        foreach(var cliente in clientes)
        {
            ImprimirCliente(cliente);
        }

        Console.ReadKey();
    }
}