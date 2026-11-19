namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6,5));
    }

    public void AulaRange()
    {
        var nomeArquivo = "2026_11_09_backup.bak";
        string ano = nomeArquivo[..4];
        System.Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        System.Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        System.Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        System.Console.WriteLine(apenasNome);
    }

    public void AulaContains()
    {
        var nomeArquivo = "2026_11_09_backup.bak";
        if(nomeArquivo.Contains("backupj"))
        {
            System.Console.WriteLine("Palavra encontrada");
        }
        else
        {
            System.Console.WriteLine("Palavra não encontrada");
        }
        //System.Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));
    }

    public void AulaTrim()
    {
        var teste = "**PEDRO HENRIQUE**";

        System.Console.WriteLine("TRIM: " + teste.Trim('*'));
        System.Console.WriteLine("TRIM: " + teste.TrimStart('*'));
        System.Console.WriteLine("TRIM: " + teste.TrimEnd('*'));
    }

    public void AulaStartWithEndsWith()
    {
        string teste = "Curso Csharp";
        
        System.Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
        System.Console.WriteLine("FINAL: " + teste.EndsWith("Csharp"));
    }

    public void AulaReplace()
    {
        string teste = "Curso Csharp";
        
        System.Console.WriteLine(teste);
        System.Console.WriteLine(teste.Replace("Csharp", "C#"));
    }

    public void AulaLength()
    {
        string teste = Console.ReadLine();
        
        System.Console.WriteLine(teste);
        System.Console.WriteLine(teste.Length);
    }
}