//Console.WriteLine("Primeiro programa!");

//top level statment

using Cadastro;
using Modulo10;

namespace Aplication;

public class Program
{
    static void Main(string[] args)
    {
        //AulaClasses();
        //AulaPropriedadeSomenteLeitura();
        //AulaHeranca();
        //AulaClasseSelada();
        //AulaClassesAbstrata();
        //AulaRecord();
        //AulaInterface();
        //AulaConversores();
        //TrabalhandoComStrings();
        //TrabalhandoComDatas();
        //TrabalhandoComExcecoes();
        //TrabalhandoComArquivos();
        TrabalhandoComLinq();
    }

    private static void TrabalhandoComLinq()
    {
        var linq = new Modulo14.TrabalhandoComLinq();
        //linq.AulaWhere();
        //linq.AulaOrdenacao();
        //linq.AulaTake();
        //linq.AulaCount();
        //linq.AulaFirstEFirstOrDefault();
        //linq.ExercicioAverage();
        //linq.ExercicioSingleOrDefault();
        linq.ExercicioMinEMax();
    }
    

    private static void TrabalhandoComArquivos()
    {
        var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
        //trabalhandoComArquivos.AulaCriandoArquivo();
        //trabalhandoComArquivos.AulaLendoArquivo();
        trabalhandoComArquivos.AulaExcluindoArquivo();
    }


    private static void TrabalhandoComExcecoes()
    {
        var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
        //trabalhandoComExcecoes.AulaGerandoException();
        trabalhandoComExcecoes.AulaTratandoException();
    }

    private static void TrabalhandoComDatas()
    {
        var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
        //trabalhandoComDatas.AulaDateTime();
        //trabalhandoComDatas.AulaSubtraindoDatas();
        //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
        //trabalhandoComDatas.AulaHoraMinutoSegundos();
        //trabalhandoComDatas.AulaDiaDaSemana();
        //trabalhandoComDatas.AulaDateOnly();
        //trabalhandoComDatas.AulaTimeOnly();
    }

    private static void TrabalhandoComStrings()
    {
        var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
        //trabalhandoComStrings.ConverterParaLetrasMinusculas();
        //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
        //trabalhandoComStrings.AulaSubstring();
        //trabalhandoComStrings.AulaRange();
        //trabalhandoComStrings.AulaContains();
        //trabalhandoComStrings.AulaTrim();
        //trabalhandoComStrings.AulaStartWithEndsWith();
        //trabalhandoComStrings.AulaReplace();
        trabalhandoComStrings.AulaLength();
    }

    private static void AulaConversores()
    {
        var conversores = new Conversores.Conversor();
        //conversores.ConvertAndParse();
        conversores.AulaTryParse();
    }
    private static void AulaInterface()
    {
        var notificacaoCliente = new Cadastro.NotificacaoCliente();
        notificacaoCliente.Notificar();
        notificacaoCliente.NotificarOutros();

        Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
        //var notificacao = new Cadastro.NotificacaoFuncionario();
        notificacao.Notificar();
    }


    private static void AulaRecord()
    {
        //var curso1 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};
        //var curso2 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};

        var curso1 = new Cadastro.Curso (1, "Curso");
        var curso2 = curso1 with { Descricao = "Teste novo"};

        //var curso1 = new Cadastro.CursoTeste {Id = 1, Descricao = "Curso"};
        //var curso2 = curso1;
        //curso2.Descricao = "TESTE, TESTE";
        //var curso2 = new Cadastro.CursoTeste();
        //curso2.Id = curso1.Id;
        //curso2.Descricao = "Nova Descrição"

        System.Console.WriteLine(curso1.Descricao);
        System.Console.WriteLine(curso2.Descricao);

        //System.Console.WriteLine(curso1 == curso2);
        //System.Console.WriteLine(curso1.Equals(curso2));
    }

    private static void AulaClassesAbstrata()
    {
        var cachorro = new Cadastro.Cachorro();
        cachorro.Nome = "Dog";
        cachorro.ImprimirDados();
    }

    private static void AulaClasseSelada()
    {
        /*var configuracao = new Cadastro.Configuracao();
        configuracao.Host = "LocalHost";
        */
        var configuracao = new Cadastro.Configuracao()
        {
            Host = "LocalHost"
        };
        Console.WriteLine(configuracao.Host);
    }
    private static void AulaHeranca()
    {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 1;
        pessoaFisica.Endereco = "Endereço Teste";
        pessoaFisica.Cidade = "Cidade Teste";
        pessoaFisica.Cep = "12345610";

        pessoaFisica.ImprimirDados();
        pessoaFisica.ImprimirCPF();
    }
    private static void AulaClasses()
    {
        var resultado = Cadastro.Calculo.SomarNumeros(3,2);
        System.Console.WriteLine(resultado);

        var produto = new Cadastro.Produto();
        produto.SetId(1);
        produto.Descricao = "Teclado";

        produto.ImprimirDescricao();
        System.Console.WriteLine(produto.GetId());
    }

    private static void AulaPropriedadeSomenteLeitura()
    {
        var produto = new Cadastro.Produto();
        produto.Descricao = "Mouse";
        //produto.Estoque = 1;
        System.Console.WriteLine(produto.Estoque);
    }
}